using NUnit.Framework;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Fluent;
using System.ComponentModel;
namespace FluentLayoutTests
{
    [TestFixture()]
    public class EventSubscriptionsTests
    {
        [Test()]
        public void BasicEventHandlerTest()
        {
            var triggerCount = 0;
            var label = new Label();
            label.Text = "initial value";

            label.WithLabelPropertyChangedEvent((sender, e) =>
            {
                triggerCount += 1;
            });

            label.Text = "Changed";
            label.Text = "ChangedAgain";

            Assert.AreEqual(2, triggerCount);
        }

        [Test()]
        public void ClassicUnsubscribeEventHandlerTest()
        {
            var triggerCount = 0;
            var label = new Label();
            label.Text = "initial value";

            PropertyChangedEventHandler handler = (sender, e) =>
            {
                triggerCount += 1;
            };

            label.WithLabelPropertyChangedEvent(handler);
            label.Text = "Changed";

            label.PropertyChanged -= handler;
            label.Text = "ChangedAgain";

            Assert.AreEqual(1, triggerCount);
        }

        [Test()]
        public void FluentUnsubscribeEventHandlerTest()
        {
            var triggerCount = 0;
            var label = new Label();
            label.Text = "initial value";

            PropertyChangedEventHandler handler = (sender, e) =>
            {
                triggerCount += 1;
            };

            label.WithLabelPropertyChangedEvent(handler);
            label.Text = "Changed";

            label.ClearLabelPropertyChangedHandlers();
            label.Text = "ChangedAgain";

            // We unsubscribed before the second Text changed
            Assert.AreEqual(1, triggerCount);
        }
    }
}
