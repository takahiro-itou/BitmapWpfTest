
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

using ViewCs;


namespace  ViewCs.Views  {

public  partial class  MainWindow : Window
{

    //----------------------------------------------------------------
    /**   デフォルトコンストラクタ。
    **
    **/
    public  MainWindow()
    {
        InitializeComponent();

        this.m_taskModel = new Models.SampleModel();
        this.m_viewModel = new ViewModels.SampleViewModel(this.m_taskModel);

        this.DataContext = this.m_viewModel;
    }


    //----------------------------------------------------------------
    /**   指定したコマンドを実行する。
    **
    **/
    private  void
    runCommand()
    {
        Bitmap    imgCanvas = new Bitmap(300, 300);
        Graphics  grpCanvas = Graphics.FromImage(imgCanvas);

        Color       colorBG = Color.FromArgb(0x80, 0x00, 0x00, 0xff);
        SolidBrush  brushBG = new SolidBrush(colorBG);
        grpCanvas.FillRectangle(brushBG, 0, 0, 300, 300);
        grpCanvas.Dispose();

        System.IntPtr hBitmap = imgCanvas.GetHbitmap();
        System.Windows.Media.Imaging.BitmapSource   bmpSrc =
            Interop.Imaging.CreateBitmapSourceFromHBitmap(
                hBitmap, IntPtr.Zero, Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
        picView.Source = bmpSrc;
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    private  void  mnuFileExit_Click(object sender, EventArgs e)
    {
        System.Windows.Application.Current.Shutdown();
    }

    //----------------------------------------------------------------
    /**
    **
    **/
    private  void  mnuRunCommand_Click(object sender, EventArgs e)
    {
        runCommand();
    }

    private Models.SampleModel          m_taskModel;
    private ViewModels.SampleViewModel  m_viewModel;

}   //  End class  MainWindow

}   //  End of namespace  ViewCs.Views
