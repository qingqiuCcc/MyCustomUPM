# MyCustomUPM （monorepo）

多模块 UPM 仓库，每个模块位于各自子文件夹，统一作用域 `com.qingqiuccc`。

## 模块一览

| 子目录 | 包名 | 依赖 | 说明 |
|--------|------|------|------|
| `Core/` | `com.qingqiuccc.core` | — | 核心模块 |

（后续模块如 `Network/`、`UI/` 依赖 core，追加到此表。）

## 安装

### 方式一：Git URL（monorepo 需用 `?path=` 指向子目录）
在项目 `Packages/manifest.json` 中：

```json
"com.qingqiuccc.core": "https://github.com/qingqiuCcc/MyCustomUPM.git?path=Core#core/1.0.0"
```

或 Unity → Package Manager → `+` → Add package from git URL：

```
https://github.com/qingqiuCcc/MyCustomUPM.git?path=Core#core/1.0.0
```

### 方式二：OpenUPM（作用域注册表）
配一次作用域注册表后即可在 Package Manager 中浏览、勾选各模块，依赖自动解析：

```json
"scopedRegistries": [
  {
    "name": "package.openupm.com",
    "url": "https://package.openupm.com",
    "scopes": [ "com.qingqiuccc" ]
  }
]
```

## 版本 / Tag 约定

monorepo 一个 tag = 整仓一个状态。为让各模块独立发版，tag 采用 **`<模块>/<版本>`** 前缀：

```
core/1.0.0
network/1.1.0
```

消费时用 `?path=Core#core/1.0.0` 精确锁定某模块某版本。

## 模块间依赖

模块 B 依赖 core 时，两处都要写：
- `B/package.json` 的 `dependencies` 加 `"com.qingqiuccc.core": "1.0.0"`
- `B` 的 asmdef `references` 加 `"QingqiuCcc.Core"`
