using System.Collections;
using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;


    public static class EventNames
{
  public static string NewDialogueEvent = "NewDialogueEvent";
}

[UnitTitle("On New Dialogue Event")]
[UnitCategory("Events\\MyEvents")]
public class NewDialogueEvent : EventUnit<DialogueNode>

{
    [DoNotSerialize]// No need to serialize ports.
  public ValueOutput result { get; private set; }// The Event output data to return when the Event is triggered.
  protected override bool register => true;

  // Add an EventHook with the name of the Event to the list of Visual Scripting Events.
  public override EventHook GetHook(GraphReference reference)
  {
      return new EventHook(EventNames.NewDialogueEvent);
  }

  protected override void Definition()
  {
      base.Definition();
      // Setting the value on our port.
      result = ValueOutput<DialogueNode>(nameof(result));
  }

  // Setting the value on our port.
  protected override void AssignArguments(Flow flow, DialogueNode data)
  {
      flow.SetValue(result, data);
  }
}


