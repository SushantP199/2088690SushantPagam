using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MagicFilesLib;
using Moq;

namespace DirectoryExplorer.Test
{
    [TestFixture]
    public class DirectoryShould
    {
        private IDirectoryExplorer _directoryExplorer;
        private readonly string _file1 = "test1.txt";
        private readonly string _file2 = "test2.txt";

        [SetUp]
        public void Initialize()
        {
            _directoryExplorer = Mock.Of<IDirectoryExplorer>(); Mock.Get(_directoryExplorer)
    .Setup(x => x.GetFiles(It.IsAny<string>()))
    .Returns((string x) =>
        new List<string>
        {
                        _file1,
                        _file2,
            //_file3
        });
        }

        [Test]
        public void GetFile_Tests()
        {
            ICollection<string> files = _directoryExplorer.GetFiles(@"C:\"); Assert.IsNotNull(files);
            Assert.IsTrue(files.Count == 2);
            Assert.IsTrue(files.Contains(_file1));
            //Assert.IsTrue(files.Contains(_file2));
            //Assert.IsTrue(files.Contains(_file3));
        }
    }
}