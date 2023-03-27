## UnityHelpTool

*UnityHelpTool*- это пакет для Unity, который добавляет полезные атрибуты для удобства использования.

### Установка

Вы можете установить *UnityHelpTool*, используя ссылку git, добавленную в ваш проект. Для этого выполните следующие
действия:

* Откройте Unity и откройте ваш проект.
* Откройте окно Package Manager, выбрав пункт меню "Window" -> "Package Manager".
* Нажмите кнопку "+" в верхнем левом углу окна Package Manager.
* Выберите "Add package from git URL" и введите ссылку на репозиторий: https://github.com/Baramlock/UnityHelpTool.git

### Добавляемые атрибуты.

* DisableIf
* EnableIf
* HideIf
* ShowIf
* ShowIfEnum
* Max
* ReadOnly

### Примеры использования

```
[SerializeField] private bool toggle1;
[SerializeField, ShowIf(nameof(toggle1))] private string text1;
[SerializeField, HideIf(nameof(toggle1))] private string text2;
[SerializeField, DisableIf(nameof(toggle1))] private string text3;
[SerializeField, EnableIf(nameof(toggle1))] private string text4;

[SerializeField, ReadOnly] private string text7;
[SerializeField, Max(20)] private int test;

[SerializeField] private Test1 _test1;
[SerializeField, ShowIfEnum(nameof(_test1), (int) Test1.test1)]
private string text5;
[SerializeField, ShowIfEnum(nameof(_test1), (int) Test1.test2)]
private string text6;

public enum Test1
{
    test1,
    test2,
}
```

