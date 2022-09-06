using XamarinTest.ViewModels;


namespace UnitTests
{
    public class BaseViewModelTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckBool()
        {
            BaseViewModel baseViewModel = new BaseViewModel();
            Assert.AreEqual(false, baseViewModel.IsBusy);
        }
    }
}