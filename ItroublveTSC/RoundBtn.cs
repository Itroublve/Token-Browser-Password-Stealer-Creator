using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundBtn : Button
{
    public RoundBtn()
    {
        this.DoubleBuffered = true;
        base.MouseEnter += delegate (object sender, EventArgs e)
        {
            this._isHovering = true;
            base.Invalidate();
        };
        base.MouseLeave += delegate (object sender, EventArgs e)
        {
            this._isHovering = false;
            base.Invalidate();
        };
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Brush brush = new SolidBrush(this._isHovering ? this._onHoverBorderColor : this._borderColor);
        graphics.FillEllipse(brush, 0, 0, base.Height, base.Height);
        graphics.FillEllipse(brush, base.Width - base.Height, 0, base.Height, base.Height);
        graphics.FillRectangle(brush, base.Height / 2, 0, base.Width - base.Height, base.Height);
        brush.Dispose();
        brush = new SolidBrush(this._isHovering ? this._onHoverButtonColor : this._buttonColor);
        graphics.FillEllipse(brush, this._borderThicknessByTwo, this._borderThicknessByTwo, base.Height - this._borderThickness, base.Height - this._borderThickness);
        graphics.FillEllipse(brush, base.Width - base.Height + this._borderThicknessByTwo, this._borderThicknessByTwo, base.Height - this._borderThickness, base.Height - this._borderThickness);
        graphics.FillRectangle(brush, base.Height / 2 + this._borderThicknessByTwo, this._borderThicknessByTwo, base.Width - base.Height - this._borderThickness, base.Height - this._borderThickness);
        brush.Dispose();
        brush = new SolidBrush(this._isHovering ? this._onHoverTextColor : this._textColor);
        SizeF sizeF = graphics.MeasureString(this.Text, this.Font);
        graphics.DrawString(this.Text, this.Font, brush, ((float)base.Width - sizeF.Width) / 2f, ((float)base.Height - sizeF.Height) / 2f);
    }
    public Color BorderColor
    {
        get
        {
            return this._borderColor;
        }
        set
        {
            this._borderColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverBorderColor
    {
        get
        {
            return this._onHoverBorderColor;
        }
        set
        {
            this._onHoverBorderColor = value;
            base.Invalidate();
        }
    }
    public Color ButtonColor
    {
        get
        {
            return this._buttonColor;
        }
        set
        {
            this._buttonColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverButtonColor
    {
        get
        {
            return this._onHoverButtonColor;
        }
        set
        {
            this._onHoverButtonColor = value;
            base.Invalidate();
        }
    }
    public Color TextColor
    {
        get
        {
            return this._textColor;
        }
        set
        {
            this._textColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverTextColor
    {
        get
        {
            return this._onHoverTextColor;
        }
        set
        {
            this._onHoverTextColor = value;
            base.Invalidate();
        }
    }

    private Color _borderColor = Color.Silver;

    private Color _onHoverBorderColor = Color.Gray;

    private Color _buttonColor = Color.Red;

    private Color _onHoverButtonColor = Color.Yellow;

    private Color _textColor = Color.White;

    private Color _onHoverTextColor = Color.Gray;

    private bool _isHovering;

    private int _borderThickness = 6;

    private int _borderThicknessByTwo = 3;
}
