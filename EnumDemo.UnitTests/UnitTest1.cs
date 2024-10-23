namespace EnumDemo.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Pour_Marcher()
        {
            // Arrange
            var nieze = new Humain(age: 15, name: "Nieze");

            // Act
            var resultat = nieze.Marcher();

            //Assert
            Assert.Equal(expected: "Je marche.", actual: resultat);

        }


        [Fact]
        public void Test_Pour_DireSlogan()
        {
            // Arrange
            // vide


            // Act
            var resultat = Humain.DireSlogan();

            //Assert
            Assert.Equal(expected: Humain.Slogan, actual: resultat);

        }
    }
}