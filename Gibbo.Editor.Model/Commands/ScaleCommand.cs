﻿#region Copyrights
/*
Gibbo2D License - Version 1.0
Copyright (c) 2013 - Gibbo2D Team
Founders Joao Alves <joao.cpp.sca@gmail.com> & Luis Fernandes <luisapidcloud@hotmail.com>

Permission is granted to use this software and associated documentation files (the "Software") free of charge, 
to any person or company. The code can be used, modified and merged without restrictions, but you cannot sell 
the software itself and parts where this license applies. Still, permission is granted for anyone to sell 
applications made using this software (for example, a game). This software cannot be claimed as your own, 
except for copyright holders. This license notes should also be available on any of the changed or added files.

The software is provided "as is", without warranty of any kind, express or implied, including but not limited to 
the warranties of merchantability, fitness for a particular purpose and non-infrigement. In no event shall the 
authors or copyright holders be liable for any claim, damages or other liability.

*/
#endregion

using Gibbo.Library;
using Microsoft.Xna.Framework;

namespace Gibbo.Editor.Model
{
    public class ScaleCommand : ICommand
    {
        #region fields

        private Vector2 _change;
        private Vector2 _beforeChange;
        private GameObject _element;

        #endregion

        #region constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="change"></param>
        /// <param name="element"></param>
        public ScaleCommand(Vector2 change, Vector2 before, GameObject element)
        {
            _change = change;
            _element = element;
            _beforeChange = before;
        }

        #endregion

        #region ICommand methods

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            _element.Transform.Scale = _change;
        }

        /// <summary>
        /// 
        /// </summary>
        public void UnExecute()
        {
            _element.Transform.Scale = _beforeChange;
        }

        #endregion
    }
}
