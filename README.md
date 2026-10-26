# IXD AR Starter

A Unity 6 project prepared for **object tracking on Android with Vuforia Engine**. The tracked object isn't included yet. Add it later by importing a Vuforia target into `Assets/Targets/`.

## Requirements

- Unity **6000.3.8f1** (Unity 6), with **Android Build Support** (SDK, NDK, OpenJDK). The student setup script installs this for you; a free Unity Personal license is activated in Unity Hub
- A free [Vuforia developer account](https://developer.vuforia.com/) and license key
- An ARCore-supported Android device (ARCore 1.45+ for Vuforia 11.2+) and a USB cable

## Get your own copy

Each student works in their **own copy** so nobody overwrites anyone else's work. You only use GitHub Desktop (a normal app with buttons). You never need to type git commands.

### One-time setup

1. **Download the setup file for your computer.** You only need this one file; the script makes your copy of the project for you in step 4. Open the file's GitHub page and click the download icon (**Download raw file**) at the top right of the code box:
   - **Mac:** [Setup-Mac.command](https://github.com/wickedcube/IXD-AR-Starter/blob/main/setup/Setup-Mac.command)
   - **Windows:** [Setup-Windows.bat](https://github.com/wickedcube/IXD-AR-Starter/blob/main/setup/Setup-Windows.bat) (it fetches the rest by itself)

   Your teacher may also hand you the file directly. Every copy of the project also contains it in the `setup` folder.
2. **Run it:**
   - **Mac:** find the file in your Downloads folder, right-click `Setup-Mac.command`, choose **Open**, then **Open** again.
   - **Windows:** double-click `Setup-Windows.bat` in your Downloads folder. If Windows warns you, click **More info > Run anyway**.

   The script shows its progress as **[1/5] ... [5/5]** and installs **GitHub Desktop** (it includes Git), **Unity Hub**, and **Unity 6000.3.8f1 with Android build support**. Unity is several GB, so it downloads in the background (about 20 to 40 minutes) while the script walks you through making your copy (steps 4 and 5) and opens the Vuforia download page (used in **Setup** step 4 below). At the end it prints a summary of what was installed and a list of what to do next. Windows may ask for administrator permission; click **Yes**. It is safe to run again if something fails: it skips what's already installed and resumes the rest.
3. **Sign in** to GitHub Desktop with your GitHub account (free at [github.com](https://github.com/signup)). The account also supplies your name and email for saves.
4. **Make your copy.** The script opens the template's **Create a new repository** page. Name your copy `ixd-ar-<yourname>`, choose **Private** (your Vuforia license key ends up in the project, so keep it private), and click **Create repository**. You can also reach that page with the green **Use this template** button on this repo's GitHub page.
5. **Download your copy to your computer.** Paste your repo address when the setup script asks (it opens the clone window for you), or in GitHub Desktop choose **File > Clone repository > URL**, paste the address, and click **Clone**.
6. In **Unity Hub** choose **Add > Add project from disk** and pick the cloned folder. The first open takes a few minutes while Unity rebuilds its cache.

> **Teacher, once:** tick **Settings > General > Template repository** on this repo's GitHub page. The repo must be public so students can download the setup file and use the template without extra access; each student's own copy is private.

**No template?** Click **Fork** at the top right of the repo page instead and clone the fork. **No GitHub at all?** Copy the whole project folder and rename it `IXD-AR-<yourname>`. You lose online backup, so copy the folder to a cloud drive or USB stick now and then.

### Make it yours

Do this once in your copy:

- [ ] Run **IXD > Apply Android AR Settings**, then in **Edit > Project Settings > Player** change **Company Name**, **Product Name** and the Android **Package Name** (e.g. `com.yourname.myar`).
- [ ] Add your own Vuforia license key (**Window > Vuforia Configuration**).
- [ ] Save your scene as `Assets/Scenes/<YourName>_Main.unity` and keep your own work in your own folders (`Assets/Scripts`, `Assets/Prefabs/TrackedContent`, `Assets/Targets`).
- [ ] Edit the title and first paragraph of this README so it describes **your** project.
- [ ] Save and back up your changes (see below).

## Setup

1. If you haven't already, open the folder in Unity Hub (**Add > Add project from disk**) with Unity 6000.3.8f1.
2. Run **IXD > Apply Android AR Settings** in the Unity menu bar. This sets IL2CPP, ARM64, min API 26, OpenGLES3 and a placeholder package name (`com.ixd.arstarter`). Change the package name in Player Settings.
3. Switch the platform to Android in **File > Build Profiles**.
4. **Install Vuforia** (once per copy). The SDK isn't stored in this repo, since it can't be redistributed and is too big for normal git. Download `add-vuforia-package-<version>.unitypackage` from the [Vuforia Developer Portal](https://developer.vuforia.com/downloads/sdk) (free account; the setup script opens this page). Then in Unity choose **Assets > Import Package > Custom Package...**, pick the file, import everything, and click **Update** when the "Add Vuforia Engine Package" window appears. Wait for Unity to finish importing.
5. Add your license key in **Window > Vuforia Configuration > App License Key**.

`IXD.AR.asmdef` compiles `TrackedObjectContent.cs` only when the Vuforia package is present, so the project still opens if you remove it.

## Adding your object later

Pick the target type that matches your object:

| Target | Best for | Made with |
| --- | --- | --- |
| **Model Target** | Rigid objects with a CAD model | [Model Target Generator](https://developer.vuforia.com/downloads/tool) |
| **Object Target** | Objects you can scan | Vuforia Object Scanner app, then Target Manager |

1. Create the target and download the database as a `.unitypackage`.
2. Import it into the project. Keep the files in `Assets/Targets/`, and drag them there if Unity placed them elsewhere.
3. In your scene, add an **ARCamera** (**GameObject > Vuforia Engine > AR Camera**).
4. Add the target with **GameObject > Vuforia Engine > Model Target** (or **Object Target**) and choose your database.
5. Add the `TrackedObjectContent` component to the target.
6. Put your 3D content, labels or UI as **children** of the target. They show when the object is tracked and hide when it is lost. Use the `onFound` and `onLost` events for sounds or animation.

## Saving and restoring your work

A "save" is a **commit**: a snapshot you can return to. Save often, such as after each thing that works. Everything below happens in GitHub Desktop.

### Save and back up

1. In Unity choose **File > Save Project** (changes that aren't written to disk won't be saved).
2. In GitHub Desktop, the **Changes** tab lists what changed. Type a short summary in the box at the bottom left, such as "added the cube", and click **Commit to main**. This is the save.
3. Click **Push origin** at the top. This is the backup to GitHub. If it says "Fetch origin" or "Pull origin" instead, click that first, then push.

Save before risky changes (upgrading a package, deleting things) and at the end of every session.

### Go back

| I want to... | Do this in GitHub Desktop |
| --- | --- |
| Throw away changes I haven't saved yet | **Changes** tab > right-click the file(s) > **Discard Changes**. |
| Undo my latest save | **History** tab > right-click the save > **Revert Changes in Commit**, then **Push origin**. This adds a new save that cancels the old one; nothing is lost. |
| Undo several saves | Revert them one at a time, newest first. |
| Look at an old version and maybe keep working from it | **History** tab > right-click the old save > **Create Branch from Commit**, name it `old-version`, and click Create. Your project folder now matches that save. To return, use **Current Branch > main**. |

Close Unity before going back, then reopen it so it re-imports.

### Mac shortcuts (optional)

Double-click these in the project folder if you prefer: **`Save My Work.command`** saves and backs up, and **`Restore My Work.command`** shows a numbered list of earlier saves and goes back to the one you pick. They need Git on your Mac, which macOS offers to install the first time. Restoring never deletes anything: your current work is saved first. If macOS refuses to open one, right-click it and choose **Open**.

For terminal users, `./tools/save.sh "message"` and `./tools/restore.sh [number] [path]` do the same.

### Good habits

- Unity's `Library/` folder is not saved because it is rebuilt automatically.
- Working in a pair on one repo? Each person should use their own branch (**Branch > New branch**) and merge only when you both stop editing the same scene. Scenes and prefabs merge badly.

### Something went wrong?

| Problem | What to do |
| --- | --- |
| "I broke my scene" | Close Unity, then **Discard Changes** (if unsaved) or **Revert Changes in Commit** (if saved). |
| Push says "rejected" or asks you to sign in | Sign in under **File > Options > Accounts** (Windows) or **GitHub Desktop > Settings > Accounts** (Mac), then try again. Your work is still saved on your computer. |
| Push says a file is too big | GitHub blocks files over 100 MB. Keep huge source files (raw video, big scans) out of the project folder, or compress them. |
| The project opens slowly the first time | Normal. Unity is rebuilding `Library/`. |
| Errors about `Vuforia` after cloning | You haven't installed the SDK in your copy yet. Do step 4 under **Setup**. |

## Project structure

```
Assets/
  Scenes/                 Your AR scene(s)
  Scripts/                IXD.AR assembly: TrackedObjectContent.cs
  Targets/                Vuforia target databases (add your object here)
  Prefabs/TrackedContent/ Content that appears on the tracked object
  Editor/                 Editor tooling (Android settings menu)
Packages/                 Package manifest (Vuforia is added when you import the SDK)
ProjectSettings/
setup/                    One-time installers for GitHub Desktop (Mac and Windows)
tools/                    save.sh and restore.sh (used by the Mac .command shortcuts)
Save My Work.command      Mac shortcut: save and back up
Restore My Work.command   Mac shortcut: go back to an earlier save
```

## Troubleshooting

- **Black screen or no tracking:** check that the camera permission is granted and the license key is set.
- **Object isn't recognized:** use even lighting, a matte textured object and a slow approach. Shiny, transparent or deformable objects track poorly.
- **Vuforia menus missing:** the SDK isn't in git. Import the `.unitypackage` as described under **Setup**, step 4.
- **Min API errors:** keep the minimum API level at 26 or higher.

## Resources

- [Vuforia Engine for Unity](https://developer.vuforia.com/library/getting-started/getting-started-unity)
- [Vuforia Model Targets](https://developer.vuforia.com/library/model-targets/model-targets-overview)
- [Vuforia release notes](https://developer.vuforia.com/library/release-notes/vuforia-engine-release-notes)

## License

Add a license of your choice (e.g. MIT) in a `LICENSE` file.
