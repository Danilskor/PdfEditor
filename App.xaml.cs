using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System.Diagnostics;
using System.Text;
using System.Windows;

namespace PDFEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            base.OnStartup(e);

            // Создание нового документа
            var document = new PdfDocument();

            // Создание новой страницы
            var page = document.AddPage();

            // Создание объекта для рисования на странице
            var gfx = XGraphics.FromPdfPage(page);

            // Добавление текста или изображений на страницу
            var font = new XFont("Arial", 12);
            gfx.DrawString("Hello, PDFsharpCore!", font, XBrushes.Black, new XRect(10, 10, page.Width, page.Height), XStringFormats.TopLeft);

            // Сохранение документа в файл
            document.Save("new_pdf_document.pdf");
        }
    }
}
