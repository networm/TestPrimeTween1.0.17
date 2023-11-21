# PrimeTween 1.0.17

## Update

- 2023-11-21

## Reproduce steps

1. Open project
2. Open Test1.unity
3. Play

## Error

```log
AssertionException: Assertion failure. Values are not equal.
Expected: 0 == 1
UnityEngine.Assertions.Assert.Fail (System.String message, System.String userMessage) (at <781ae7ac455e4981a7a57fe4b3a3ae5b>:0)
UnityEngine.Assertions.Assert.AreEqual[T] (T expected, T actual, System.String message, System.Collections.Generic.IEqualityComparer`1[T] comparer) (at <781ae7ac455e4981a7a57fe4b3a3ae5b>:0)
UnityEngine.Assertions.Assert.AreEqual[T] (T expected, T actual, System.String message) (at <781ae7ac455e4981a7a57fe4b3a3ae5b>:0)
PrimeTween.Assert.AreEqual[T] (T expected, T actual, System.String msg) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Internal/Assert.cs:7)
PrimeTween.ReusableTween.rewindIncrementalTween () (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Internal/ReusableTween.cs:155)
PrimeTween.Sequence.restart_internal () (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Sequence.cs:395)
PrimeTween.Sequence.restart () (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Sequence.cs:376)
PrimeTween.Sequence.onTweenKilled (System.Int32 tweenId) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Sequence.cs:235)
PrimeTween.ReusableTween.updateSequenceAfterKill () (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Internal/ReusableTween.cs:401)
PrimeTween.Tween+<>c.<StopAll>b__838_0 (PrimeTween.ReusableTween tween) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/TweenMethods.cs:30)
PrimeTween.PrimeTweenManager.processAll_internal (System.Object onTarget, System.Predicate`1[T] predicate, System.Nullable`1[T] minExpected, System.Nullable`1[T] numMaxExpected) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Internal/PrimeTweenManager.cs:379)
PrimeTween.PrimeTweenManager.processAll (System.Object onTarget, System.Predicate`1[T] predicate, System.Nullable`1[T] numMinExpected, System.Nullable`1[T] numMaxExpected) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/Internal/PrimeTweenManager.cs:367)
PrimeTween.Tween.StopAll (System.Object onTarget, System.Nullable`1[T] numMinExpected, System.Nullable`1[T] numMaxExpected) (at Library/PackageCache/com.kyrylokuzyk.primetween@2728f0d0794b-1699791494000/Runtime/TweenMethods.cs:28)
Test1.Update () (at Assets/Test1.cs:20)
```

## Key

`SetCycles()` is the key line. If you don't set it at all, then all things works perfectly.

