using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void AccountCreation_ShouldInitializeBalance()
    {
        // Arrange
        int initialAmount = 1000;
        // Act
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(1000));
    }

    [Test]
    public void PositiveDeposit_ShouldIncreasesBalance()
    {
        // Arrange
        int initialAmount = 1000;
        int depositAmount = 500;
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Act
        bankAccount.Deposit(depositAmount);
        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(1500));
    }

    [Test]
    public void NegativeDeposit_ShouldThrowArgumentException()
    {
        // Arrange
        int initialAmount = 1000;
        int depositAmount = -500;
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Act + Assert
        Assert.That(() => bankAccount.Deposit(depositAmount), Throws.ArgumentException);
    }

    [Test]
    public void ValidWithdrawl_ShouldDecreasesBalance()
    {
        // Arrange
        int initialAmount = 1000;
        int withdrawAmount = 500;
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Act
        bankAccount.Withdraw(withdrawAmount);
        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(500));
    }

    [Test]
    public void NegativeWithdrawl_ThrowsArgumentException()
    {
        // Arrange
        int initialAmount = 1000;
        int withdrawAmount = -500;
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Act + Assert
        Assert.That(() => bankAccount.Withdraw(withdrawAmount), Throws.ArgumentException);
    }

    [Test]
    public void ExceedingWithdrawl_ShouldThrowArgumentException()
    {
        // Arrange
        int initialAmount = 100;
        int withdrawAmount = 500;
        BankAccount bankAccount = new BankAccount(initialAmount);
        // Act + Assert
        Assert.That(() => bankAccount.Withdraw(withdrawAmount), Throws.ArgumentException);
    }
}
