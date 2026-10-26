# Targets

Drop tracked-object databases here when you have your object.

- **Model Target:** the `.unitypackage` exported from Vuforia Model Target Generator.
- **Object Target:** the `.unitypackage` exported from the Vuforia Object Scanner / Target Manager.

After importing, add the target via **GameObject > Vuforia Engine > Model Target** (or **Object Target**),
pick your database/target, then add `TrackedObjectContent` to it and place your content as children.
