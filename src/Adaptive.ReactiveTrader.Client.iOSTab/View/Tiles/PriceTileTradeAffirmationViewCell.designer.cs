// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Adaptive.ReactiveTrader.Client.iOSTab.Tiles
{
	[Register ("PriceTileTradeAffirmationViewCell")]
	partial class PriceTileTradeAffirmationViewCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel CounterCCY { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel CurrencyPair { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Direction { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DirectionAmount { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DirectionCCY { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton DoneButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Rate { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TradeId { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TraderId { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel ValueDate { get; set; }

		[Action ("Done:")]
		partial void Done (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CounterCCY != null) {
				CounterCCY.Dispose ();
				CounterCCY = null;
			}

			if (CurrencyPair != null) {
				CurrencyPair.Dispose ();
				CurrencyPair = null;
			}

			if (Direction != null) {
				Direction.Dispose ();
				Direction = null;
			}

			if (DirectionAmount != null) {
				DirectionAmount.Dispose ();
				DirectionAmount = null;
			}

			if (DirectionCCY != null) {
				DirectionCCY.Dispose ();
				DirectionCCY = null;
			}

			if (DoneButton != null) {
				DoneButton.Dispose ();
				DoneButton = null;
			}

			if (Rate != null) {
				Rate.Dispose ();
				Rate = null;
			}

			if (ValueDate != null) {
				ValueDate.Dispose ();
				ValueDate = null;
			}
				
			if (TradeId != null) {
				TradeId.Dispose ();
				TradeId = null;
			}

			if (TraderId != null) {
				TraderId.Dispose ();
				TraderId = null;
			}
		}
	}
}
