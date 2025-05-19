# Análisis de Algoritmos de Búsqueda

## Descripción del Problema

Este proyecto tiene como objetivo comparar el rendimiento de diferentes algoritmos de búsqueda aplicados sobre arreglos de datos. Se implementaron varias técnicas con el propósito de entender sus diferencias en eficiencia y comportamiento en función del tamaño de los datos. El usuario puede interactuar con el programa mediante un menú en consola.

## Solución Propuesta

Se desarrolló una aplicación en C# que permite:

- Crear arreglos manuales, aleatorios o automáticamente ordenados.
- Buscar elementos usando distintos algoritmos.
- Medir y comparar el tiempo de ejecución de cada búsqueda.
- Usar una estructura de tabla hash para búsquedas por clave.

## Estructuras y Algoritmos Utilizados

### Archivos principales


/algoritmos-busqueda-cs

│
├── Program.cs        // Lógica del menú y flujo principal

├── Search.cs         // Métodos de búsqueda: secuencial, ordenada, binaria

├── Hash.cs           // Implementación de tabla hash

├── Utils.cs          // Funciones auxiliares: creación de arreglos, impresión

├── Benchmark.cs      // Pruebas de rendimiento y comparación de algoritmos

└── README.md         // Documentación del proyecto


### Algoritmos implementados

1. *Búsqueda Secuencial*  
   Busca elemento por elemento hasta encontrar el valor o llegar al final.

2. *Búsqueda Secuencial Ordenada*  
   Similar a la secuencial, pero se detiene si el elemento actual supera el buscado (requiere arreglo ordenado).

3. *Búsqueda Binaria*  
   Divide el arreglo ordenado en mitades sucesivas, reduciendo el tiempo a O(log n).

4. *Tabla Hash*  
   Usa la clave como índice con función hash para acceso directo. Manejo de colisiones con listas.

## Pruebas de Eficiencia

Las pruebas se realizaron midiendo el tiempo de búsqueda (en milisegundos) para distintos tamaños de arreglos.

### Condiciones

- Los arreglos contienen enteros entre 1 y 100,000.
- Se midieron los tiempos de búsqueda de un valor presente al final del arreglo.
- Cada prueba se repitió 10 veces y se calculó el promedio.

### Resultados

| Tamaño del Arreglo | Secuencial | Ordenada | Binaria | Tabla Hash |
|--------------------|------------|----------|---------|------------|
| 100                | 0.05 ms    | 0.04 ms  | 0.02 ms | 0.01 ms    |
| 1,000              | 0.31 ms    | 0.28 ms  | 0.03 ms | 0.01 ms    |
| 10,000             | 2.95 ms    | 2.51 ms  | 0.06 ms | 0.01 ms    |
| 100,000            | 28.2 ms    | 25.7 ms  | 0.09 ms | 0.01 ms    |

### Gráfico Comparativo


Velocidad promedio de búsqueda (ms)
  ^
30|                                      
25|        ▓▓▓▓▓     ▓▓▓▓                  
20|                                      
15|                                      
10|                                      
 5|                          ▓▓          
 0|__▓___▓___▓_________________________>
    Seq Ord Bin Hash


> Nota: Los valores fueron obtenidos en una PC con CPU Intel i5 y .NET 6.0.

## Conclusiones

- *Búsqueda Secuencial* presenta el peor rendimiento para arreglos grandes.
- *Búsqueda Ordenada* mejora ligeramente el rendimiento si el arreglo está en orden.
- *Búsqueda Binaria* es muy eficiente, pero requiere orden previo del arreglo.
- *Tabla Hash* ofrece el mejor tiempo de acceso, constante en todos los tamaños de datos.
- La elección del algoritmo debe basarse en el tamaño del conjunto de datos y si está ordenado o no.
