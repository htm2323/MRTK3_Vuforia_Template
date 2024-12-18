# MRTK3 + Vuforia 開発テンプレート
HoloLens2向けMRアプリケーションを開発するために，MRTK3 + Vuforia 10 で開発を行うためのテンプレートのUnityプロジェクトです．
Image Targetの使用を想定したSample Sceneを作成しています．
HoloLens上でデバッグを行うため，デバッグメッセージを表示するプレハブ等を含んでいます．

## 動作確認環境
- HoloLens2
- Unity 2022.3.51f1
- MRTK3
  - MRTK Core Definitions 4.0.0-pre.1
  - MRTK Input 4.0.0-pre.1
  - MRTK Spatial Manipulation 4.0.0-pre.1
  - MRTK UX components 4.0.0-pre.1
  - MRTK UX components 4.0.0-pre.1
  - MRTK UX Core Scripts 4.0.0-pre.1
  - Mixed Reality OpenXR Plugin 1.11.1
  - Microsoft Spatializer 2.0.55
- Vuforia 10.27

## 導入(HoloLens2向け)
1. Unityで本プロジェクトを開く（SafeModeに入る）
2. Mixed Reality Feature Toolで **MRTK3の各種パッケージ** をimport
3. Exit SafeModeする
4. MRTK3の設定を行う
   - Build Settingsから**platform を UWP に**し，**Architecture を ARM 64bit に**変更
   - ProjectSettingsを開く
     - MRTK3 タブで **Assign MRTK Default** を押してプロファイルを設定
     - XR Plug-in Managementタブで **OpenXR と Microsoft HoloLens feature group** を選択し，HoloLens2向けビルド設定を行う
     - PlayerタブでPublishing Settingsを開き，**Certificcateファイルを作成**する（Vuforiaのものは古いため）
5. PackageManager もしくは UnityPackageで **Vuforia Engine** をimport
   - この時，ProjectSettings以下のファイルのimport選択画面で，**Noneで全ての選択を外して**importする
6. SampleSceneを開き，TextMeshProをimport
7. `Assets/Resources/VuforiaConfiguration.asset`から**VuforiaのAPIキーを記入**
