# Control-work
## Задача: ##
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] →[“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.* 

## Алгоритм решения ##
1. Создали строковый массивю
2. Создали метод, заполняющий массив (*FillArray*), заполняющий массив значениямиб ввенными пользователем.
3. Создали метод вывода заполненного массива поэлементно на экран (*PrintArray*).
4. Создали метод , определяющий длинну нового массива (*GetSizeOfSecondArray*).
5. Сщздали условие окончания решения. Если размер второго массива равен нулю.
6. Создали метод, переносящий определенны по условию задания элементы из изначального массива в новый (*TransferElements*)
7. Вывели на экра новый массив.
## Блок-схема алгоритма ##

![](Diagram\BlockTask.png)