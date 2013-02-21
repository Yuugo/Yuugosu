using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Yuugosu
{
    class ScoreObject
    {
        Texture2D h300;
        Texture2D h200;
        Texture2D h100;
        Texture2D h000;
        int startTime;
        int type;
        Texture2D scoreTexture;
        Vector2 location = new Vector2(0,0);

        public enum String
        {
            hit0 = 0, hit50 = 1, hit100 = 2, hit300 = 3
        }

        public ScoreObject(int st, int t, ContentManager content)
        {
            startTime = st;
            type = t;
            
        }

        public void LoadContent(ContentManager content)
        {
            if(type == 3)
                scoreTexture = content.Load<Texture2D>("Skin/hit300");
            else if(type == 2)
                scoreTexture = content.Load<Texture2D>("Skin/hit100");
            else if(type == 1)
                scoreTexture = content.Load<Texture2D>("Skin/hit50");
            else
                scoreTexture = content.Load<Texture2D>("Skin/hit0");
        }

        public void setLocation(int x, int y)
        {
            location = new Vector2(x, y);
            if (type == 0)
                location = new Vector2(location.X - 106 / 2, location.Y - 106 / 2);
        }

        public void Draw(SpriteBatch sb, int time)
        {
            if (!(time > startTime + 1500))
                sb.Draw(scoreTexture, location, Color.White);
        }

    }
}
