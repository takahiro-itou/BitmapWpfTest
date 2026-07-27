
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
    **
    private  void  mnuRunCommand_Click(object sender, EventArgs e)
    {
        runCommand();
    }

    private Models.SampleModel          m_taskModel;
    private ViewModels.SampleViewModel  m_viewModel;

}   //  End class  MainWindow

}   //  End of namespace  ViewCs.Views
