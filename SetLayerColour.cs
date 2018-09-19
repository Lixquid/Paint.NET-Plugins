// Name: Set Layer Colour
// Submenu: Object
// Author: Lixquid
// Title: Set Layer Colour
// Version: 0.1.0

void Render(Surface dst, Surface src, Rectangle rect) {
    var PrimaryColor = EnvironmentParameters.PrimaryColor;

    ColorBgra CurrentPixel;
    for (var y = rect.Top; y < rect.Bottom; y++) {
        if (IsCancelRequested) return;
        for (var x = rect.Left; x < rect.Right; x++) {
            CurrentPixel = src[x,y];
            CurrentPixel.R = PrimaryColor.R;
            CurrentPixel.G = PrimaryColor.G;
            CurrentPixel.B = PrimaryColor.B;
            dst[x,y] = CurrentPixel;
        }
    }
}
