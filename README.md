# Задание, выполненное для компании MindBox
## <i>Исполнитель:</i> Даниил Шатравка

## Описание 

Программа представляет собой библиотеку классов для работы с геометрическими фигурами Круг и Треугольник. 

Библиотека классов находится в [данной](./FigureService/) папке.

Тестовое покрытие представлено [здесь](./FigureServiceTest/).

## Иерархия классов
Классы [Triangle](./FigureService/Triangle.cs) и [Round](./FigureService/Round.cs) являются наследниками класса [Figure](./FigureService/Figure.cs). Это позволит с легкостью добавлять другие фигуры при необходимости.

Вызов свойства Area можно производить над сущностями не зная их класс.

В класс [Triangle](./FigureService/Triangle.cs) добавлен метод `IsRightTriangle()`, который возвращает значение в зависимости от того, является ли треугольник прямоугольным или нет. 