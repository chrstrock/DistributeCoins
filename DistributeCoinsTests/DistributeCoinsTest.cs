using NUnit.Framework;
using DistributeCoins;

namespace DistributeCoinsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ThreeZeroZeroReturnsTwo()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(0);
            root.right = new TreeNode(0);
            Coins coins = new Coins();
            Assert.AreEqual(2, coins.DistributeCoins(root));
        }

        [Test]
        public void ZeroThreeZeroReturnsThree()
        {
            TreeNode root = new TreeNode(0,new TreeNode(3), new TreeNode(0));
            
            Coins coins = new Coins();
            Assert.AreEqual(3, coins.DistributeCoins(root));
        }
    }
}