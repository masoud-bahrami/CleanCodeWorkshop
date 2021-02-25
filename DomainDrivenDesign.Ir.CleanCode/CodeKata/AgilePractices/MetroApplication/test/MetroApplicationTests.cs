using System.Collections.Generic;
using MetroApp.AbstractFactory;
using MetroApp.Command;
using MetroApp.Decorator;
using MetroApp.Facade;
using MetroApp.Observer;
using MetroApp.State;
using MetroApp.Template;
using MetroApp.UnitTests.TestSpecificClasses;
using Xunit;

namespace MetroApp.UnitTests
{
    public class MetroApplicationTests
    {
        [Fact]
        public void BuyMultiTripsCard()
        {
            CardAbstractFactory factory = new CardAbstractFactory();
            var oneTripCard= factory.CreateMultiTripsCard(MultiTripsCardType.OneTrip);
            Assert.False(oneTripCard.IsExpired());
            Assert.Equal(1, oneTripCard.AllowedTrips());

            var twoTripsCard = factory.CreateMultiTripsCard(MultiTripsCardType.TwoTrips); 
            
            Assert.False(twoTripsCard.IsExpired());
            Assert.Equal(2, twoTripsCard.AllowedTrips());
        }

        [Fact]
        public void BuyMetroCard()
        {
            CardAbstractFactory factory = new CardAbstractFactory();
            var chargeMetroCardWith50000InitialAmount= factory.CreateChargableMetroCard(initialAmount: 50000);

            Assert.False(chargeMetroCardWith50000InitialAmount.IsExpired());
            Assert.Equal(50000, chargeMetroCardWith50000InitialAmount.Balance());

            var chargeMetroCardWith100000InitialAmount = factory.CreateChargableMetroCard(initialAmount: 100000);

            Assert.False(chargeMetroCardWith100000InitialAmount.IsExpired());
            Assert.Equal(100000, chargeMetroCardWith100000InitialAmount.Balance());
        }

        [Fact]
        public void TestMetroGetaway()
        {
            CardAbstractFactory facade = new CardAbstractFactory();
            var twoTripCard = facade.CreateMultiTripsCard(MultiTripsCardType.TwoTrips);
            MetroGetawayFacade getaway = new MetroGetawayFacadeDecorator();

            getaway.Process(twoTripCard);

            Assert.True(new MetroGetawayInstantiator().Instance().IsOpen());
            Assert.False(twoTripCard.IsExpired());
            Assert.Equal(1, twoTripCard.AllowedTrips());
        }

        [Fact]
        public void TestMetroGetaway1()
        {
            new MetroGetawayInstantiator().Instance().IsOpen();

            CardAbstractFactory facade = new CardAbstractFactory();
            var oneTripCard = facade.CreateMultiTripsCard(MultiTripsCardType.OneTrip);
            oneTripCard.CountDownNumberOfAllowedTrips();

            MetroGetawayFacade getaway = new MetroGetawayFacadeDecorator();

            getaway.Process(oneTripCard);
            Assert.False(new MetroGetawayInstantiator().Instance().IsOpen());
        }

        [Fact]
        public void OpenMetroGetaway_WithChargeAbleCard_WhenBalanceIsNotEnough()
        {
            new MetroGetawayInstantiator().Instance().IsOpen();

            CardAbstractFactory facade = new CardAbstractFactory();
            var oneTripCard = facade.CreateChargableMetroCard(9999);

            MetroGetawayFacade getaway = new MetroGetawayFacadeDecorator();

            getaway.Process(oneTripCard);
            Assert.True(new MetroGetawayInstantiator().Instance().IsOpen());
            Assert.Equal(50000 - 10000, oneTripCard.Balance());
        }


        [Fact]
        public void ChargeMetroCard()
        {
            CardAbstractFactory factory = new CardAbstractFactory();
            var initialCardBalance = 9999;
            var chargableMetroCard = factory.CreateChargableMetroCard(initialCardBalance);

            Mediator.Mediator mediator = new Mediator.Mediator();
            IChargeCardWriterUi chargeCardWriterUi = new ChargeCardWriterCompositeUi(new List<IChargeCardWriterUi>
            {
                new SpeechChargeCardWriterUi(),
                new PrintChargeCardWriterUi()
            });

            var newAmount = 50000;

            IChargeCardReaderUi chargeCardReaderUi = ChargeCardReaderUiStub.Config(new ChargeMetroCard
            {
                Amount = newAmount,
                BankCardNumber = "123456",
                Password = "123456789",
                Card = chargableMetroCard
            });

            IChargeMetroCardTemplate chargeMetroCardTemplate = new ChargeMetroCardByPOS(mediator, chargeCardWriterUi, chargeCardReaderUi);
            ChargeMetroCardSubject chargeMetroCardObservable = new ChargeMetroCardSubject();
            
            chargeMetroCardObservable.RegisterObserver(new ChargeMetroCardObserverStub(newAmount + initialCardBalance, .006M));

            ChargeMetroCardFacade facade = new ChargeMetroCardFacade(chargeMetroCardTemplate , chargeMetroCardObservable);
            facade.Charge();

            Assert.Equal(newAmount + initialCardBalance + (newAmount + initialCardBalance) * .006M, chargableMetroCard.Balance());
        }
    }
}
