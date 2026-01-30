using System.Numerics;

public struct Point2 {
    public int X, Y;

    public Point2() {
    }

    public Point2(int X, int Y) {
        this.X = X;
        this.Y = Y;
    }

    public Point2(Point2 p) {
        this.X = p.X;
        this.Y = p.Y;
    }

    public Vector2 Vector2() {
        return new Vector2(X, Y);
    }

    public static Point2 operator+(Point2 a, Point2 b) { return new Point2(a.X + b.X, a.Y + b.Y); }
    public static Point2 operator-(Point2 a, Point2 b) { return new Point2(a.X - b.X, a.Y - b.Y); }
    public static Point2 operator-(Point2 a) { return new Point2(-a.X, -a.Y); }
    public static Point2 operator*(Point2 a, Point2 b) { return new Point2(a.X * b.X, a.Y * b.Y); }
    public static Point2 operator/(Point2 a, Point2 b) { return new Point2(a.X / b.X, a.Y / b.Y); }

    public static Point2 operator*(Point2 a, int b) { return new Point2(a.X * b, a.Y * b); }
    public static Point2 operator*(int a, Point2 b) { return new Point2(a * b.X, a * b.Y); }
    public static Point2 operator/(Point2 a, int b) { return new Point2(a.X / b, a.Y / b); }
    public static Point2 operator*(Point2 a, float b) { return new Point2((int)(a.X * b), (int)(a.Y * b)); }
    public static Point2 operator*(float a, Point2 b) { return new Point2((int)(a * b.X), (int)(a * b.Y)); }
    public static Point2 operator/(Point2 a, float b) { return new Point2((int)(a.X / b), (int)(a.Y / b)); }

    public static bool operator==(Point2 a, Point2 b) { return a.X == b.X && a.Y == b.Y; }
    public static bool operator!=(Point2 a, Point2 b) { return a.X != b.X || a.Y != b.Y; }

    public override bool Equals(object? o) {
        if(o == null)
            return false;
        if(!(o is Point2))
            return false;
        return (Point2)o == this;
    }

    public override int GetHashCode() {
        return this.X.GetHashCode() ^ this.Y.GetHashCode();
    }

    public static Point2
        Zero  = new Point2(0, 0),
        One   = new Point2(1, 1),
        UnitX = new Point2(1, 0),
        UnitY = new Point2(0, 1);
}
