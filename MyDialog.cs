using Android.Content;
using Android.OS;
using View = Android.Views.View;
using Google.Android.Material.BottomSheet;
using Android.Views;
using AndroidX.AppCompat.App;

namespace MapAndBottmSheetExample;

public class MyDialog : BottomSheetDialog, View.IOnTouchListener {
    public View Content { get; set; }
    private Context ActivityContext { get; }

    public MyDialog(Context context) : base(context) {
        ActivityContext = context;
    }

    protected override void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);
        SetContentView(Content);
        Window.ClearFlags(WindowManagerFlags.DimBehind);

        View touchView = FindViewById<View>(Resource.Id.touch_outside);
        touchView?.SetOnTouchListener(this);
    }

    public void ShowDialog() {
        if (!IsShowing)
            Show();
    }

    public bool OnTouch(View v, MotionEvent e) {
        (ActivityContext as AppCompatActivity).DispatchTouchEvent(e);
        return true;
    }
}