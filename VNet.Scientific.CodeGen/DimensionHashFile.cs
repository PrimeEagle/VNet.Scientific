using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using VNet.CodeGeneration.Log;

// ReSharper disable NotAccessedField.Local
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.Scientific.CodeGen
{
    public class DimensionHashFile
    {
        private readonly string _fileName;
        private readonly string _directory;

        public List<FileHashEntry> Entries { get; set; }

        public DimensionHashFile(string fileName)
        {
            _fileName = fileName;
            _directory = Path.GetDirectoryName(_fileName);
            
            if (!File.Exists(fileName))
            {
                var fs = File.Create(fileName);
                fs.Close();
            }

            string json;
            using (var reader = new StreamReader(fileName))
            {
                json = reader.ReadToEnd();
                reader.Close();
            }

            Entries = string.IsNullOrEmpty(json) ? new List<FileHashEntry>() : JsonSerializer.Deserialize<List<FileHashEntry>>(json);
            foreach (var e in Entries)
            {
                e.FullPath = _directory + e.FileName;
            }
        }

        public IEnumerable<FileHashEntry> GetUpdatedEntries()
        {
            return Entries.Where(e => e.Updated);
        }

        public void Update()
        {
            foreach (var entry in Entries)
            {
                // deleted files
                if (!File.Exists(entry.FileName))
                {
                    entry.Deleted = true;
                    continue;
                }

                // updated files
                if (entry.Hash != GetFileHash(entry.FileName))
                {
                    entry.Updated = true;
                }
            }

            Entries.RemoveAll(e => e.Deleted);

            // new files
            var files = Directory.GetFiles(_directory, "*.json").Where(f => !f.Contains(_fileName));

            
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);

                if (Entries.All(e => e.FileName != fileName))
                {
                    var newEntry = new FileHashEntry()
                    {
                        FileName = fileName,
                        FullPath = file,
                        Hash = GetFileHash(file),
                        Updated = true,
                        Deleted = false
                    };
                    Entries.Add(newEntry);
                }
            }
        }

        private static string GetFileHash(string fileName)
        {
            var sha256 = SHA256.Create();
            var stream = File.OpenRead(fileName);
            var buffer = new byte[8192]; // 8KB chunks
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0) sha256.TransformBlock(buffer, 0, bytesRead, null, 0);
            sha256.TransformFinalBlock(buffer, 0, 0);

            var builder = new StringBuilder();
            foreach (var t in sha256.Hash)
                builder.Append(t.ToString("x2"));

            stream.Dispose();
            sha256.Dispose();

            return builder.ToString().Replace("-", "").ToLowerInvariant();
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(Entries.Where(e => !e.Deleted).Select(e => new { e.FileName, e.Hash }));
            using (var writer = new StreamWriter(_fileName))
            {
                writer.Write(json);
                writer.Close();
            }
        }
    }
}