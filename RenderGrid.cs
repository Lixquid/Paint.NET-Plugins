// Name: Render Grid
// Submenu: Render
// Author: Lixquid
// Title: Render Grid
// Version: 0.1.0

#region UICode
IntSliderControl Amount1 = 16; // [1,1024] Grid X
IntSliderControl Amount2 = 16; // [1,1024] Grid Y
IntSliderControl Amount3 = 0; // [-1023,1023] Offset X
IntSliderControl Amount4 = 0; // [-1023,1023] Offset Y
#endregion

bool PositiveGrid(int x, int y) {
    return
        (x + Amount3) % (Amount1 * 2) < Amount1 && (y + Amount4) % (Amount2 * 2) < Amount2
        || (x + Amount3) % (Amount1 * 2) >= Amount1 && (y + Amount4) % (Amount2 * 2) >= Amount2;
}

void Render(Surface dst, Surface src, Rectangle rect) {
    var PrimaryColor = EnvironmentParameters.PrimaryColor;
    var SecondaryColor = EnvironmentParameters.SecondaryColor;

    ColorBgra CurrentPixel;
    for (var y = rect.Top; y < rect.Bottom; y++) {
        if (IsCancelRequested) return;
        for (var x = rect.Left; x < rect.Right; x++) {
            dst[x,y] = PositiveGrid(x, y) ? PrimaryColor : SecondaryColor;
        }
    }
}
