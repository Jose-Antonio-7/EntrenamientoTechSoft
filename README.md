# EntrenamientoTechSoft

### Principios de Programación Orientada  a Objetos
> La Programación Orientada a Objetos (POO) es un paradigma de programación que se basa en el uso de objetos, que son instancias de clases, para representar y manipular datos. Los principios de POO son un conjunto de reglas y conceptos que guían la forma en que se deben diseñar y programar los objetos y las clases en un sistema POO. Algunos de los principios más importantes de POO son
>
> 1. Encapsulamiento: se refiere a la capacidad de los objetos de ocultar su estado interno y protegerlo de modificaciones externas. Esto se logra definiendo las propiedades y métodos de una clase como públicos, privados o protegidos.
> 
> 1. Abstracción: es la capacidad de representar un objeto del mundo real en términos de sus características y comportamientos esenciales, ignorando los detalles no relevantes. Esto se logra definiendo una interfaz clara y concisa para la interacción con un objeto, y ocultando los detalles de implementación.
> 
> 1. Herencia: es la capacidad de crear nuevas clases a partir de clases existentes, reutilizando y extendiendo su funcionalidad. Esto se logra mediante la definición de una clase base y la creación de clases derivadas que heredan sus propiedades y métodos.
> 
> 1. Polimorfismo: es la capacidad de un objeto de comportarse de diferentes maneras según el contexto. Esto se logra mediante la definición de métodos con el mismo nombre en diferentes clases, que se comportan de manera distinta según la clase del objeto que los invoque.

### Principios SOLID
> Los Principios SOLID son un conjunto de cinco principios de diseño de software que fueron introducidos por el ingeniero de software Robert C. Martin en su libro "Agile Software Development, Principles, Patterns, and Practices". Los principios SOLID se centran en la creación de código limpio, estructurado y fácilmente mantenible. Estos principios son:
> 
> 1. Principio de Responsabilidad Única (SRP, Single Responsibility Principle): Este principio establece que una clase o módulo debe tener una única responsabilidad en el sistema, es decir, debe haber una sola razón para cambiarla. Esto significa que una clase debe tener una única tarea o función y no debe mezclar varias funcionalidades dentro de sí misma.
> 
> 1. Principio de Abierto/Cerrado (OCP, Open/Closed Principle): Este principio establece que las entidades del software (clases, módulos, etc.) deben estar abiertas para su extensión, pero cerradas para su modificación. Es decir, cuando se necesite agregar nuevas funcionalidades al software, se debe hacer mediante la adición de nuevas clases o módulos, y no modificando los existentes.
> 
> 1. Principio de Sustitución de Liskov (LSP, Liskov Substitution Principle): Este principio establece que una clase derivada debe ser capaz de sustituir a su clase base sin causar errores o comportamientos inesperados en el sistema. En otras palabras, una clase derivada debe comportarse de la misma manera que su clase base, pero con funcionalidades adicionales.
> 
> 1. Principio de Segregación de Interfaces (ISP, Interface Segregation Principle): Este principio establece que las interfaces de una clase o módulo deben ser específicas y cohesivas, y no deben contener métodos que no sean utilizados por la clase o módulo que los implementa. Esto permite que una clase o módulo sólo tenga acceso a las funcionalidades que realmente necesita.
> 
> 1. Principio de Inversión de Dependencias (DIP, Dependency Inversion Principle): Este principio establece que las clases de nivel superior no deben depender de las clases de nivel inferior, sino que ambos niveles deben depender de abstracciones. Esto significa que los detalles de implementación deben depender de abstracciones, y no al revés.

### Principio YAGNI
> El principio YAGNI (You Ain't Gonna Need It) es un principio de programación que se utiliza en el contexto de la metodología ágil de desarrollo de software. Este principio establece que no se deben añadir características o funcionalidades que no son necesarias en el momento actual del proyecto, incluso si se piensa que pueden ser útiles en el futuro.

### Principio KISS
> El principio KISS (Keep It Simple, Stupid) es un principio de diseño que se utiliza en la programación, la ingeniería de software y otros campos relacionados. El objetivo de este principio es hacer que el software sea fácil de entender, de mantener y de utilizar mediante la simplificación del diseño.

### Singleton
> Singleton: es un patrón que se utiliza para garantizar que sólo exista una instancia de una clase en todo el sistema. Esto se logra mediante la restricción del acceso al constructor y la creación de una instancia global que se puede acceder desde cualquier parte del sistema.

### Decorator
> Decorator: es un patrón que se utiliza para añadir funcionalidades a un objeto existente sin alterar su estructura básica. Esto se logra mediante la creación de una clase que envuelve a la clase base y que añade las funcionalidades adicionales.

### Clases Abstractas
> En programación orientada a objetos, una clase abstracta es una clase que no se puede instanciar directamente, sino que se utiliza como una plantilla para crear otras clases. Una clase abstracta define un conjunto de métodos y propiedades que pueden ser heredados por las clases hijas, pero que no se pueden implementar directamente en la clase abstracta.

### Interfaces
> En C#, una interfaz es una colección de miembros (métodos, propiedades, eventos y otros) que se definen sin una implementación concreta. En otras palabras, una interfaz es un contrato que define los métodos y propiedades que una clase debe implementar, pero no cómo se deben implementar.

### Diferencia entre interfaz y clase abstracta 
Implementación: Las clases abstractas pueden tener implementaciones concretas, mientras que las interfaces no pueden tener implementaciones concretas de sus miembros.

> 1. Herencia: Una clase puede heredar de una única clase abstracta, mientras que puede implementar múltiples interfaces.
>
> 1. Modificadores de acceso: Los miembros de una clase abstracta pueden tener modificadores de acceso (public, private, protected, etc.), mientras que los miembros de una interfaz siempre son públicos.
>
> 1. Propiedades: Las clases abstractas pueden tener propiedades concretas, mientras que las interfaces no pueden tener propiedades concretas.
>
> 1. Constructores: Las clases abstractas pueden tener constructores, mientras que las interfaces no pueden tener constructores.
>
> 1. Palabras clave: En C#, se utiliza la palabra clave "abstract" para definir una clase abstracta y la palabra clave "interface" para definir una interfaz.

### Objetos Estáticos 
> En la programación orientada a objetos, un objeto estático es un objeto que pertenece a una clase en lugar de a una instancia de esa clase. Los objetos estáticos se definen en la clase y existen independientemente de cualquier instancia de la clase.
> 
> En otras palabras, un objeto estático es una variable o un método que se puede llamar directamente desde la clase, sin necesidad de crear una instancia de la clase. Por ejemplo, una clase "Math" puede tener un método estático "Max" que devuelve el número máximo entre dos valores. Este método se puede llamar directamente desde la clase "Math", sin necesidad de crear una instancia de la clase.

### Métodos de Extensión
> Los métodos de extensión son una funcionalidad de C# que permite agregar nuevos métodos a una clase existente sin tener que modificar la definición original de la clase. Los métodos de extensión se definen en una clase separada y se agregan a una clase existente utilizando la palabra clave "this" en el primer parámetro del método.

### ORM
> ORM significa "Object-Relational Mapping" (Mapeo Objeto-Relacional) y es una técnica utilizada en programación para mapear los objetos de una aplicación con las tablas de una base de datos relacional.
> 
> ORM se encarga de la tarea de mapear los objetos de la aplicación con las tablas de la base de datos, y viceversa, sin tener que escribir código SQL directamente. Esto se logra mediante el uso de una capa de abstracción que convierte las operaciones de la base de datos en objetos y operaciones de la aplicación.

### Entity Framework
> Entity Framework es un framework de mapeo objeto-relacional (ORM) desarrollado por Microsoft y que se utiliza en aplicaciones .NET. Su objetivo es simplificar el acceso a datos de una base de datos relacional a través de objetos y clases de .NET, eliminando la necesidad de escribir SQL directamente.

### Dapper
> Dapper es un micro-ORM (Object-Relational Mapping) de código abierto desarrollado por los ingenieros de Stack Overflow. Dapper es un framework de mapeo objeto-relacional (ORM) ligero que extiende la funcionalidad del ADO.NET (ActiveX Data Objects .NET), permitiendo a los desarrolladores trabajar con bases de datos relacionales de manera más fácil y eficiente.

### MVC
> MVC is a pattern that separates an application into three interconnected components: Model, View, and Controller. The Model represents the data and business logic of the application, the View is responsible for rendering the user interface, and the Controller handles user input and manages the flow of data between the Model and the View.

### MVVM
> MVVM is a variation of the MVC pattern that is commonly used in building client-side applications, particularly those using a graphical user interface (GUI). MVVM separates an application into three components: Model, View, and ViewModel. The Model and View components are similar to those in the MVC pattern, but the ViewModel acts as an intermediary between the Model and the View. The ViewModel is responsible for presenting the data from the Model to the View in a way that is easy to display and interact with.

### DDD
> DDD (Diseño Dirigido por el Dominio) es un enfoque de desarrollo de software que se enfoca en el modelo de dominio y el lenguaje utilizado para describirlo. Fue introducido por Eric Evans en su libro "Domain-Driven Design: Tackling Complexity in the Heart of Software" en 2004.
> 
> En su núcleo, DDD tiene como objetivo crear software que refleje el dominio empresarial en el que opera, siendo el modelo de dominio el principio organizativo central del sistema. El modelo de dominio es un modelo conceptual del dominio que captura los conceptos clave, las relaciones y las reglas que rigen el negocio.

### ONION
> The Onion Architecture is a software architectural pattern that promotes the separation of concerns within an application by defining layers that have specific responsibilities and dependencies. It was introduced by Jeffrey Palermo in 2008 as an alternative to the traditional three-tier architecture.
> 
> - At the center of the Onion Architecture is the Domain Model, which represents the business logic and rules of the application. This is the core of the architecture, and it is surrounded by layers that are increasingly dependent on external systems and frameworks. These layers are:
> 
> - Domain Layer: This layer contains the domain model, which is responsible for the business logic of the application. It is independent of any other layer and does not have any dependencies on external systems or frameworks.
> 
> - Application Layer: This layer contains the application logic and coordinates the interaction between the UI, the domain model, and the infrastructure layer. It depends on the domain layer but is independent of any specific UI or infrastructure technology.
> 
> - Infrastructure Layer: This layer contains the implementation details that support the application, such as the database, file system, or web services. It depends on both the domain and application layers, but those layers do not depend on it.

UI Layer: This layer contains the user interface, such as a web page or a desktop application. It depends on the application layer, but the application layer is independent of any specific UI technology.

### N-LAYER
> N-Layer (también conocido como Multitier) es una arquitectura de software que se utiliza para diseñar aplicaciones empresariales escalables y flexibles. Esta arquitectura se basa en la idea de dividir una aplicación en capas lógicas o niveles, donde cada capa es responsable de una tarea específica.
> 
> Cada capa se divide en funciones lógicas separadas, con una comunicación clara y bien definida entre cada capa. Los datos fluyen a través de estas capas, pasando por la capa de presentación (que es la interfaz de usuario), la capa de aplicación (que maneja la lógica de la aplicación), la capa de servicios (que proporciona servicios al resto de la aplicación) y la capa de acceso a datos (que interactúa con la base de datos subyacente).
> 
> Las capas se comunican mediante interfaces bien definidas, lo que permite una mayor flexibilidad y facilidad de mantenimiento en el caso de cambios en los requisitos de la aplicación. Además, la separación de responsabilidades entre las capas permite que cada una se pruebe y depure de forma independiente, lo que aumenta la calidad general del software.

### TDD
> TDD (Test-Driven Development) es una práctica de programación que se utiliza para desarrollar software en la que las pruebas automatizadas se escriben antes de que se escriba el código de la funcionalidad.
> 
> En TDD, el ciclo de desarrollo sigue tres fases:
> 
> Escribir una prueba automatizada para la funcionalidad que se va a implementar.
> 1. Ejecutar la prueba automatizada y asegurarse de que falle, ya que aún no se ha implementado la funcionalidad.
> 1. Escribir el código necesario para que la prueba automatizada pase satisfactoriamente.
> 1. Luego se repite este ciclo para cada nueva funcionalidad que se implemente.

### BDD
> BDD (Behavior-Driven Development) es una metodología de desarrollo de software que se centra en la colaboración entre los miembros del equipo de desarrollo y los interesados en el negocio para asegurarse de que el software se está construyendo de acuerdo con las necesidades del negocio.
> 
> BDD se enfoca en describir el comportamiento esperado del software desde una perspectiva del negocio. Esto se logra mediante la definición de escenarios de aceptación y el uso de un lenguaje común, denominado lenguaje de dominio específico (DSL), que se utiliza para describir el comportamiento del sistema en términos de requisitos del negocio. Los escenarios de aceptación son descripciones concretas y detalladas de cómo se espera que el software funcione en situaciones específicas.
> 
> BDD sigue un ciclo de desarrollo similar al TDD, pero en lugar de enfocarse en pruebas unitarias, se centra en la especificación de comportamiento. El ciclo de desarrollo de BDD se puede resumir en tres pasos:
> 
> 1. Descubrimiento: El equipo de desarrollo y los interesados en el negocio colaboran para definir los escenarios de aceptación y el lenguaje de dominio específico.
> 1. Especificación: Se escribe el código que especifica el comportamiento del sistema y se verifica que los escenarios de aceptación se cumplan.
> 1. Automatización: Se automatizan los escenarios de aceptación para asegurar que el software sigue funcionando correctamente en el futuro.

### Microservicios
> Los microservicios son una arquitectura de software que consiste en diseñar aplicaciones como un conjunto de servicios pequeños e independientes que se comunican entre sí a través de una red. Cada servicio se enfoca en una tarea específica y se puede desarrollar, probar, desplegar y escalar de forma independiente.
> 
> En una arquitectura de microservicios, cada servicio se ejecuta en su propio proceso y puede ser desarrollado con diferentes lenguajes de programación, bases de datos y tecnologías. Cada servicio se expone a través de una interfaz bien definida, lo que permite que los servicios se comuniquen entre sí a través de la red.
> 
> Los microservicios permiten una mayor agilidad y escalabilidad en el desarrollo de software, ya que los servicios pueden ser desarrollados y desplegados de forma independiente. Además, los microservicios pueden ser escalados verticalmente o horizontalmente según la demanda, lo que permite un uso más eficiente de los recursos del servidor.
