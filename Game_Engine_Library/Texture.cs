﻿using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Game_Engine_Library {
    public class Texture {
        /// <summary>
        /// Идентификатор текстуры.
        /// </summary>
        public virtual int ID { get; private set; }

        /// <summary>
        /// Ширина текстуры.
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Высота текстуры.
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Создание новой текстуры.
        /// </summary>
        /// <param name="id">Идентификатор текстуры.</param>
        /// <param name="width">Ширина текстуры.</param>
        /// <param name="height">Высота текстуры.</param>
        public Texture(int id, int width, int height) {
            ID = id;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Загрузка текстуры из файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns>Загруженная текстура.</returns>
        public static Texture LoadTexture(string path) {
            int id = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, id);
            
            Bitmap bitmap = new Bitmap(path);
            BitmapData data = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0,
                PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra,
                PixelType.UnsignedByte, data.Scan0);

            bitmap.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D,
                TextureParameterName.TextureWrapS,
                (int)TextureWrapMode.Clamp);
            GL.TexParameter(TextureTarget.Texture2D,
                TextureParameterName.TextureWrapT,
                (int)TextureWrapMode.Clamp);

            GL.TexParameter(TextureTarget.Texture2D,
                TextureParameterName.TextureMinFilter,
                (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D,
                TextureParameterName.TextureMagFilter,
                (int)TextureMagFilter.Nearest);

            return new Texture(id, bitmap.Width, bitmap.Height);
        }
    }
}
