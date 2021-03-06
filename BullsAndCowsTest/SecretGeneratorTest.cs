﻿using BullsAndCows;
using Moq;
using Xunit;

namespace BullsAndCowsTest
{
    public class SecretGeneratorTest
    {
        [Fact]
        public void Should_Create_Secret_Generator()
        {
            var secretGenerator = new SecretGenerator();
            Assert.NotNull(secretGenerator);
        }

        [Fact]
        public void Should_Generat_4_Digits()
        {
            //given
            var secretGenerator = new SecretGenerator();
            var secret = secretGenerator.GenerateSecret();

            //when
            var secretLength = 4;

            //then
            Assert.Equal(secret.Length, secretLength);
        }

        [Fact]
        public void Should_different_Between_2_Digits()
        {
            //given
            var secretGenerator = new SecretGenerator();
            var secret = secretGenerator.GenerateSecret();

            //when
            var secret1 = secretGenerator.GenerateSecret();

            //then
            Assert.NotEqual(secret, secret1);
        }
    }
}