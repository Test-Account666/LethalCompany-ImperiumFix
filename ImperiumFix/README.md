# ImperiumFix

Fixes a longstanding issue with Imperium.
Specifically, errors like this one:

```
[14:56:17.1767915] [Error  : Unity Log] Exception 'NullReferenceException' thrown from state change monitor 'InputActionState' on 'DiscreteButton:/Keyboard/ctrl'
[14:56:17.1767915] [Error  : Unity Log] NullReferenceException: Object reference not set to an instance of an object
Stack trace:
UnityEngine.InputSystem.InputActionState.ProcessInteractions (UnityEngine.InputSystem.InputActionState+TriggerState& trigger, System.Int32 interactionStartIndex, System.Int32 interactionCount) (at <dbb0ce7b96144bd8bcbcb8b0d765f970>:IL_003E)
UnityEngine.InputSystem.InputActionState.ProcessControlStateChange (System.Int32 mapIndex, System.Int32 controlIndex, System.Int32 bindingIndex, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr) (at <dbb0ce7b96144bd8bcbcb8b0d765f970>:IL_024D)
UnityEngine.InputSystem.InputActionState.UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged (UnityEngine.InputSystem.InputControl control, System.Double time, UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, System.Int64 mapControlAndBindingIndex) (at <dbb0ce7b96144bd8bcbcb8b0d765f970>:IL_000E)
UnityEngine.InputSystem.InputManager.FireStateChangeNotifications (System.Int32 deviceIndex, System.Double internalTime, UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr) (at <dbb0ce7b96144bd8bcbcb8b0d765f970>:IL_008E)
UnityEngine.InputSystem.LowLevel.<>c__DisplayClass7_0:<set_onUpdate>b__0(NativeInputUpdateType, NativeInputEventBuffer*)
UnityEngineInternal.Input.NativeInputSystem:NotifyUpdate(NativeInputUpdateType, IntPtr)
```

Not only do they pollute your logs everytime you press ctrl/space, but the flight system also breaks.

One known temporary work-around is to re-assign the `Toggle Flight`, `Flying Ascend` and `Flying Descend` keybinds.
You'd have to do this for every boot though.

Also note: Not everyone seems to have this issue. If you don't have it, lucky you!

This is a band-aid fix until Imperium officially fixes this.<br>
It works by reloading all Imperium keybinds whenever you join/host a lobby.

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/P5P6ZWLCY)
