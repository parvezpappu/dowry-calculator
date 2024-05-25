using System.Drawing.Drawing2D;

public class CircularButton : Button
{
    public CircularButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
        this.Region = new Region(path); // Set the button's region to the circle

        base.OnPaint(e);
    }
}