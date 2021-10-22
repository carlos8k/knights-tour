using Bunit;
using KnightsTour.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KnightsTour.Tests.Components
{
    public class ChessBoardComponentTests : TestContext
    {
        [Fact]
        public void CounterStartsAtZero()
        {
            // Arrange
            var cut = RenderComponent<ChessBoardComponent>();

            // Act

            // Assert
        }
    }
}