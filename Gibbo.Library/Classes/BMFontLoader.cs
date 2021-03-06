﻿#region Copyrights
/*
Gibbo2D - Copyright - 2013 Gibbo2D Team
Founders - Joao Alves <joao.cpp.sca@gmail.com> and Luis Fernandes <luisapidcloud@hotmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE. 
*/
#endregion
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Gibbo.Library.Classes
{
    /// <summary>
    /// 
    /// </summary>
    public class BMFontLoader
    {
        #region fields

        private static Dictionary<string, BitmapFontRenderer> fontRenderers = new Dictionary<string, BitmapFontRenderer>();

        #endregion

        #region constructors

        /// <summary>
        /// The available font renderers
        /// </summary>
        public static Dictionary<string, BitmapFontRenderer> FontRenderers
        {
            get { return BMFontLoader.fontRenderers; }
        }

        #endregion

        #region methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fntFilePath"></param>
        /// <param name="fontTexturePath"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static BitmapFontRenderer AddBMFont(string fntFilePath, string fontTexturePath, string name)
        {
            if(!fontRenderers.ContainsKey(name))
            {
                string _fntFilePath = System.IO.Path.Combine(SceneManager.GameProject.ProjectPath, fntFilePath);
                string _textureFilePath = System.IO.Path.Combine(SceneManager.GameProject.ProjectPath, fontTexturePath);

#if WINDOWS
                if (File.Exists(_fntFilePath) && File.Exists(_textureFilePath))
#elif WINRT
                if(MetroHelper.AppDataFileExists(_fntFilePath) && MetroHelper.AppDataFileExists(_textureFilePath))
#endif
                {
                    FontFile fontFile = FontLoader.Load(_fntFilePath);
                    Texture2D fontTexture = TextureLoader.FromFile(_textureFilePath);

                    BitmapFontRenderer fr = new BitmapFontRenderer(fontFile, fontTexture);
                    fontRenderers[name] = fr;

                    return fr;
                }
            }

            return null;
        }

        /// <summary>
        /// Clears the renderers cache
        /// </summary>
        public static void Clear()
        {
            fontRenderers.Clear();
        }

        #endregion
    }
}
