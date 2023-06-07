using System.Linq;

namespace Minusix
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyCommand : BaseCommand<MyCommand>
    {
        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            TestDialog dialog = new TestDialog();
            dialog.ShowDialog();
        }
    }
}
