using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SFML.Graphics;
using SFML.Window;


namespace FS.Core
{
    class GameCore
    {
        static void Main()
        {
            Core.LoadFiles.LoadPlayerTexture();
            Core.LoadFiles.FirstStart();
            Render.CoreRender.StartRender();
        }
    }
}
