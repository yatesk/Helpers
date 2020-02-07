using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Helpers
{
    class Button
    {
        private Texture2D texture;
        private SpriteFont font;
        private Vector2 position;

        private string text;
        private Color textColor;

        private bool mouseOver;

        public Button(Texture2D _texture, SpriteFont _font, Vector2 _position, string _text, Color _textColor)
        {
            texture = _texture;
            font = _font;
            position = _position;
            text = _text;
            textColor = _textColor;
        }

        public bool ButtonClick(int _x, int _y)
        {
            if (_x >= position.X && _x <= position.X + texture.Width && _y >= position.Y && _y <= position.Y + texture.Height)
                return true;
            else
                return false;
        }

        public void Update(int _x, int _y)
        {
            if (_x >= position.X && _x <= position.X + texture.Width && _y >= position.Y && _y <= position.Y + texture.Height)
                mouseOver = true;
            else
                mouseOver = false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (mouseOver)
            {
                spriteBatch.Draw(texture, position, Color.Gray);
            }
            else
                spriteBatch.Draw(texture, position);

            // center text
            int x = 5;
            int y = 5;

            spriteBatch.DrawString(font, text, new Vector2(x, y), textColor);
        }
    }
}