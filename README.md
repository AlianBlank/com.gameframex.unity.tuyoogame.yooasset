# 基于`com.tuyoogame.yooasset` 的二次修改

该库主要服务于 `https://github.com/AlianBlank/GameFrameX` 作为子库使用。


# 使用方式(三种方式)
1. 直接在 `manifest.json` 文件中添加以下内容
   ```json
      {"com.tuyoogame.yooasset": "https://github.com/AlianBlank/com.tuyoogame.yooasset.git"}
    ```
2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/AlianBlank/com.tuyoogame.yooasset.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别

# 改动功能

1. 增加验证等级VeryHigh 为 Md5 文件哈希校验。
2. 增加版本号的自动生成和点击生成新版本号。采用当前时间
3. 增加资源对象`IsSucceed` 属性，标识是否加载成功
4. 增加防裁剪的帮助类。需要在启动的主场景中挂载 `YooAssetCroppingHelper` 脚本即可

# 官方文档

[https://www.yooasset.com/docs/Introduce](https://www.yooasset.com/docs/Introduce)

当前同步的版本信息：
https://github.com/tuyoogame/YooAsset/commit/6f13c021b9af26299ff08a4a384146b3ede9ebed