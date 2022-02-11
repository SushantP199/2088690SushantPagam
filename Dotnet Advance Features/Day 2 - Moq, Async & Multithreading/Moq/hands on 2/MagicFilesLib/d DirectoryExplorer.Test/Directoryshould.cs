using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using MagicFilesLib;
using NUnit.Framework;

namespace d_DirectoryExplorer.Test
{
    internal class Directoryshould
    {

        private readonly string _file1 = "file.txt";

        private readonly string _file2 = "file2.txt";

        private Mock<IDirectoryExplorer> _directoryExplorer;
        [SetUp]
        public void Int()
        {

            _directoryExplorer = new Mock<IDirectoryExplorer>();
            _directoryExplorer.Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns((string x) =>
                    new List<string>
                    {
                        _file1,
                        _file2,

                    });
        }


        [Test]
        public void DirectoryTest()
        {

            ICollection<string> files = _directoryExplorer.Object.GetFiles(@"C:\");

            // the collection is not null
            Assert.IsNotNull(files);

            // is there exit only 2 files 
            Assert.AreEqual(2, files.Count);

            // the collection contains _file1
            Assert.IsTrue(files.Contains(_file1));

        }
    }
}

    
