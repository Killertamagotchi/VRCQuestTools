---
sidebar_position: 2
---

# Convert Avatar

Convert your avatar to Quest compatible.

## Prerequisite Knowledge

- Basic knowledge of Unity for VRChat
- How to upload your avatar to VRChat
- [Avatar Fallback System](https://docs.vrchat.com/docs/avatar-fallback-system)

## Upload PC Avatar

Before converting your avatar, you should upload your avatar for PC platform.

## Convert Avatar

Convert your avatar to Quest compatible.

1. Select your avatar in Hierarchy.
2. Right-click on the avatar and select **VRCQuestTools** > **Convert Avatar for Quest**.
3. **Convert Avatar for Quest** window appears.
4. Click **Convert** button of the window.
5. Converted avatar is created in the same scene. Its name has the suffix `(Quest)`.

:::note
The original avatar is deactivcated after conversion. You can restore it from the inspector.
:::

:::caution
VRCQuestTools never optimize avatar performance.
So in most cases, converted avatars would have "Very Poor" performance rank in Quest platform.

In Quest platform, minimum displayed performance rank of safety can be "Good" or "Poor". This means "Very Poor" avatars are always blocked and replaced with your fallback avatar unless other people individually change Avatar Display setting (as known as "Show Avatar" functionality).

You should set an appropriate fallback avatar.
:::

## Reduce Avatar Dynamics Components

Quest avatar has a hard cap for Avatar Dynamics (PhysBones, Colliders and Contacts). If your avatar has too many PhysBones, you should reduce them.

https://docs.vrchat.com/docs/avatar-performance-ranking-system#quest-limits

- 8 PhysBone components
- 64 PhysBones affected transforms
- 16 PhysBones colliders
- 64 PhysBones collider checks
- 16 Avatar Dynamics Contacts

In other words, even if your avatar is ranked as "Very Poor", you must pass "Poor" performance rank in Avatar Dynamics category at least.

1. When your converted avatar exceeded the limit, **PhysBones Remover** window appears.
2. Select the checkbox of PhysBones and others you want to keep.
3. Click **Delete Unselected Components** button.

## Switch Platform to Android

To upload your avatar to Quest platform, you should switch platform to Android.

1. Select **File** > **Build Settings** in the menu bar.
2. Select **Android** in the Platform list.
3. Click **Switch Platform** button.
4. Wait for a while until the process is finished. At first time, it takes a long time.

:::note
Result of the switching platform is saved in the project since Unity 2019. So you don't need to wait for a long time from next time.
:::

:::tip
In some situation, you can use [Unity Accelerator](https://docs.unity3d.com/Manual/UnityAccelerator.html) to speed up the switching platform process.
See [Unity Documentation](https://docs.unity3d.com/Manual/UnityAccelerator.html) for details.
:::

## Upload Quest Avatar

Now you can upload the converted avatar to Quest platform. Make sure the original avatar and the converted avatar uses the same Blueprint ID in Pipeline Manager.

After uploading, make sure the avatar thumbnail has the Quest icon.

:::note
Avatars are managed by Blueprint ID. So you can upload avatar data for each platform with the same Blueprint ID.
PC players will see the original avatar and Quest players will see the converted avatar.
:::