using Raylib_CsLo;

namespace BadLib;

public static class Gui
{
    public enum State
    {
        STATE_NORMAL,
        STATE_FOCUSED,
        STATE_PRESSED,
        STATE_DISABLED,
    }

    public enum TextAlignment
    {
        TEXT_ALIGN_LEFT,
        TEXT_ALIGN_CENTER,
        TEXT_ALIGN_RIGHT,
    }

    public enum Control
    {
        // Default -> populates to all controls when set
        DEFAULT = 0,
        // Basic controls
        LABEL,          // Used also for: LABELBUTTON
        BUTTON,
        TOGGLE,         // Used also for: TOGGLEGROUP
        SLIDER,         // Used also for: SLIDERBAR
        PROGRESSBAR,
        CHECKBOX,
        COMBOBOX,
        DROPDOWNBOX,
        TEXTBOX,        // Used also for: TEXTBOXMULTI
        VALUEBOX,
        SPINNER,        // Uses: BUTTON, VALUEBOX
        LISTVIEW,
        COLORPICKER,
        SCROLLBAR,
        STATUSBAR
    }

    public enum ControlProperty
    {
        BORDER_COLOR_NORMAL,
        BASE_COLOR_NORMAL,
        TEXT_COLOR_NORMAL,
        BORDER_COLOR_FOCUSED,
        BASE_COLOR_FOCUSED,
        TEXT_COLOR_FOCUSED,
        BORDER_COLOR_PRESSED,
        BASE_COLOR_PRESSED,
        TEXT_COLOR_PRESSED,
        BORDER_COLOR_DISABLED,
        BASE_COLOR_DISABLED,
        TEXT_COLOR_DISABLED,
        BORDER_WIDTH,
        TEXT_PADDING,
        TEXT_ALIGNMENT,
        RESERVED,
    }

    public enum DefaultProperty
    {
        TEXT_SIZE = 16,             // Text size (glyphs max height)
        TEXT_SPACING,               // Text spacing between glyphs
        LINE_COLOR,                 // Line control color
        BACKGROUND_COLOR,           // Background color
    }

    public enum ToggleProperty
    {
        GROUP_PADDING = 16,         // ToggleGroup separation between toggles
    }

    public enum SliderProperty
    {
        SLIDER_WIDTH = 16,          // Slider size of internal bar
        SLIDER_PADDING              // Slider/SliderBar internal bar padding
    }

    public enum ProgressBarProperty
    {
        PROGRESS_PADDING = 16,      // ProgressBar internal padding
    }

    public enum ScrollBarProperty
    {
        ARROWS_SIZE = 16,
        ARROWS_VISIBLE,
        SCROLL_SLIDER_PADDING,      // (SLIDERBAR, SLIDER_PADDING)
        SCROLL_SLIDER_SIZE,
        SCROLL_PADDING,
        SCROLL_SPEED,
    }

    public enum CheckBoxProperty
    {
        CHECK_PADDING = 16,         // CheckBox internal check padding
    }

    public enum ComboBoxProperty
    {
        COMBO_BUTTON_WIDTH = 16,    // ComboBox right button width
        COMBO_BUTTON_SPACING,       // ComboBox button separation
    }

    public enum DropdownBoxProperty
    {
        ARROW_PADDING = 16,         // DropdownBox arrow separation from border and items
        DROPDOWN_ITEMS_SPACING,     // DropdownBox items separation
    }

    public enum TextBoxProperty
    {
        TEXT_INNER_PADDING = 16,    // TextBox/TextBoxMulti/ValueBox/Spinner inner text padding
        TEXT_LINES_SPACING,         // TextBoxMulti lines separation
    }

    public enum SpinnerProperty
    {
        SPIN_BUTTON_WIDTH = 16,     // Spinner left/right buttons width
        SPIN_BUTTON_SPACING,        // Spinner buttons separation
    }

    public enum ListViewProperty
    {
        LIST_ITEMS_HEIGHT = 16,     // ListView items height
        LIST_ITEMS_SPACING,         // ListView items separation
        SCROLLBAR_WIDTH,            // ListView scrollbar size (usually width)
        SCROLLBAR_SIDE,             // ListView scrollbar side (0-left, 1-right)
    }

    public enum ColorPickerProperty
    {
        COLOR_SELECTOR_SIZE = 16,
        HUEBAR_WIDTH,               // ColorPicker right hue bar width
        HUEBAR_PADDING,             // ColorPicker right hue bar separation from panel
        HUEBAR_SELECTOR_HEIGHT,     // ColorPicker right hue bar selector height
        HUEBAR_SELECTOR_OVERFLOW    // ColorPicker right hue bar selector overflow
    }

    public enum PropertyElement
    {
        BORDER = 0,
        BASE,
        TEXT,
        OTHER,
    }

    public readonly static int SCROLLBAR_LEFT_SIDE = 0;
    public readonly static int SCROLLBAR_RIGHT_SIDE = 1;

    public static void SetFontSize(int fontSize)
    {
        RayGui.GuiSetStyle((int)Control.DEFAULT, (int)DefaultProperty.TEXT_SIZE, fontSize);
    }
}
