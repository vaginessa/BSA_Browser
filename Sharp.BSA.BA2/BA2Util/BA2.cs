﻿using System;
using System.IO;
using SharpBSABA2.Enums;
using SharpBSABA2.Extensions;

namespace SharpBSABA2.BA2Util
{
    public class BA2 : Archive
    {
        public BA2Header Header { get; set; }

        public bool UseATIFourCC { get; set; } = false;

        public new int FileCount => (int)Header.NumFiles;
        public new bool HasNameTable => Header.NameTableOffset > 0;
        public new string VersionString => Header.Version.ToString();

        public BA2(string filePath) : base(filePath)
        {
        }

        protected override void Open(string filePath)
        {
            this.Header = new BA2Header(BinaryReader);
            // Set more detailed archive type, used for comparing
            this.Type = this.ConvertType(this.Header.Type);

            for (int i = 0; i < this.FileCount; i++)
                switch (this.Header.Type)
                {
                    case BA2HeaderType.GNRL: Files.Add(new BA2FileEntry(this)); break;
                    case BA2HeaderType.DX10: Files.Add(new BA2TextureEntry(this)); break;
                    case BA2HeaderType.GNMF: Files.Add(new BA2GNFEntry(this)); break;
                    default:
                        throw new Exception($"Unknown {nameof(BA2HeaderType)} value: " + this.Header.Type);
                }

            if (this.HasNameTable)
            {
                // Seek to name table
                BinaryReader.BaseStream.Seek((long)Header.NameTableOffset, SeekOrigin.Begin);

                // Assign full names to each file
                for (int i = 0; i < this.FileCount; i++)
                    this.Files[i].FullPath = BinaryReader.ReadString(BinaryReader.ReadInt16());
            }
        }

        /// <summary>
        /// Converts <see cref="BA2HeaderType"/> to <see cref="ArchiveTypes"/> for more detailed information.
        /// </summary>
        private ArchiveTypes ConvertType(BA2HeaderType type)
        {
            if (Enum.TryParse("BA2_" + this.Header.Type, out ArchiveTypes typeConverted))
                return typeConverted;
            else
                throw new Exception($"Unable to convert value '{this.Header.Type}' to {nameof(ArchiveTypes)}");
        }
    }
}
