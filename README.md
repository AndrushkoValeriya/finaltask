# Задача:

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Примеры:

> [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
> [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
> [“Russia”, “Denmark”, “Kazan”] → []

# Решение:

**Шаг 1.** Вводим в консоль количество элементов исходного массива  

**Шаг 2.** Создаем метод, где вводим по-очередно каждый элемент массива  

**Шаг 3.** Создаем функцию отбора элементов с количеством символов, не превышающих 3. Формируем новый массив с этими элементами  

**Шаг 4.** Создаем метод выводв нового массива