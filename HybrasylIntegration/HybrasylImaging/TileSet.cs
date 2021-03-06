﻿/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2016 Project Hybrasyl (info@hybrasyl.com)
 *
 */

using Hybrasyl.IO;
using System.Collections.Generic;
using System.IO;

namespace Hybrasyl.Imaging
{
    public class Tileset
    {
        public const int TileWidth = 56;
        public const int TileHeight = 27;
        public const int TileSize = TileWidth * TileHeight;
        private string name;
        private string filename;
        private int tileCount;

        private List<byte[]> tiles = new List<byte[]>();

        public byte[] this[int index]
        {
            get { return tiles[index]; }
            set { tiles[index] = value; }
        }

        public string FileName
        {
            get { return filename; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte[][] Tiles
        {
            get { return tiles.ToArray(); }
        }

        public int TileCount
        {
            get { return tileCount; }
        }

        public static Tileset FromFile(string file)
        {
            FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read);
            Tileset tileset = LoadTiles(stream);
            tileset.name = Path.GetFileNameWithoutExtension(file).ToUpper();
            tileset.filename = file;
            return tileset;
        }

        public static Tileset FromRawData(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            Tileset tileset = LoadTiles(stream);
            tileset.name = "Unknown TileSet";
            return tileset;
        }

        public static Tileset FromArchive(string file, Archive archive)
        {
            if (!archive.Contains(file)) return null;

            Tileset tileset = LoadTiles(new MemoryStream(archive.ExtractFile(file)));
            tileset.name = Path.GetFileNameWithoutExtension(file).ToUpper();
            tileset.filename = file;

            return tileset;
        }

        public static Tileset FromArchive(string file, bool ignoreCase, Archive archive)
        {
            if (!archive.Contains(file, ignoreCase)) return null;

            Tileset tileset = LoadTiles(new MemoryStream(archive.ExtractFile(file, ignoreCase)));
            tileset.name = Path.GetFileNameWithoutExtension(file).ToUpper();
            tileset.filename = file;

            return tileset;
        }

        private static Tileset LoadTiles(Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            BinaryReader reader = new BinaryReader(stream);

            Tileset tileset = new Tileset();
            tileset.tileCount = (int)(reader.BaseStream.Length / TileSize);

            for (int i = 0; i < tileset.tileCount; i++)
            {
                byte[] tileData = reader.ReadBytes(TileSize);
                tileset.tiles.Add(tileData);
            }
            reader.Close();

            return tileset;
        }
    }
}