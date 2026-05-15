using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[UnitTitle("Purchased Item Event")]
[UnitCategory("Events\\MyEvents")]
public class PurchasedItem : EventUnit<PurchaseButton>
{
    [DoNotSerialize]
  public ValueOutput result { get; private set; }// The Event output data to return when the Event is triggered.
  protected override bool register => true;

  // Add an EventHook with the name of the Event to the list of Visual Scripting Events.
  public override EventHook GetHook(GraphReference reference)
  {
      return new EventHook(EventNames.PurchasedItem);
  }

  protected override void Definition()
  {
      base.Definition();
      // Setting the value on our port.
      result = ValueOutput<PurchaseButton>(nameof(result));
  }

  // Setting the value on our port.
  protected override void AssignArguments(Flow flow, PurchaseButton data)
  {
      flow.SetValue(result, data);
  }
}
