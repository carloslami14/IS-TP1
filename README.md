# IS_TP1_2017
Ingenieria del Software - 2017 - 4K2 - Trabajo Practico N°1: "El Operador Turismo"

1. INTRODUCCIÓN 
1.1. Objetivo 
    El propósito de este documento es encontrar, definir y analizar las necesidades de alto nivel y las características para el nuevo sistema del Operador Turístico. Mediante el documento visión se determinarán los requisitos funcionales del nuevo sistema. Se prevé una aplicación capaz de gestionar los procesos administrativos de la organización. Se trata de una empresa que gestiona los paquetes turísticos que serán comercializados por la red de agencias de turismo.

2. ORIENTACIÓN 
2.1. Oportunidades de Negocio 
    Se trata de un producto a medida especialmente desarrollado para El Operador Turístico, aunque podría servir para cualquier empresa en el mismo rubro.

2.2. Enunciado del Problema
    Actualmente La Agencia no cuenta con software específico para gestionar los paquetes turísticos. La información es administrada con planillas de cálculos y archivos manuscritos. Con el crecimiento experimentado en los últimos años este mecanismos de manejo de la información resulta insuficiente, además de los inconvenientes conocidos, dificultad para análisis de datos complejos, duplicidad de información, imposibilidad de intercambio de datos, etc. El nuevo desarrollo deberá contemplar todas las funciones requeridas para representar los procesos del negocio, y esto se llevará a cabo mediante un proceso iterativo. 
 
 
3. RESUMEN DE CARACTERÍSTICAS DEL NEGOCIO 
 
3.1. Detalle:
    La estructura de comercialización de paquetes turístico establece una jerarquía de tres niveles: 
          Operadores Definen los paquetes y las salidas que luego se comercializarán, crean los lazos comerciales con los prestadores.
          Mayoristas Se encargan de que las salidas se materialicen, coordinando que los servicios se ejecuten según lo previsto.    
          Minoristas Utilizan los canales de ventas para llegar a los cliente finales.
          
    Los paquetes turísticos constituyen la descripción de todo lo que incluye una propuesta turística. En esencia, un paquete define: nombre, descripción, itinerario, condiciones comerciales, días, noches, ciudad de origen, ciudades de destino, pasos fronterizos y todos los servicios incluidos. Un paso fronterizo es un destacamento ubicado en el límite político internacional por donde es posible el tránsito de entrada y salida terrestre de un país.
    
    Estos servicios pueden ser, por ejemplo, una butaca (en un determinado transporte), una noche de alojamiento (en un determinado hotel), excursiones, comidas, seguros, etc. En detalle:
    ● Primero se define el rubro: Transporte, Alojamiento, Excursión, etc.
    ● Luego siguen los tipos: Transporte → Ómnibus;  Alojamiento → Hotel, etc.
    ● Por último se define el servicio propiamente: Ómnibus → Butaca; Hotel → Noche de Hotel, etc. 
 
    Además, los servicios vinculados a un paquete establecen un rango de días (desde y hasta) de duración dentro del paquete. Es decir, si un paquete tiene una duración de 11 días, un servicio se puede ofrecer desde el día 1 al día 5, otro desde el día 6 al 11, etc.    Cuando se define un nuevo paquete, por defecto, se encuentra en el estado Creado, luego de incluir toda la información requerida (ver requerimientos específicos) puede pasar al estado Activo y en cualquier momento se podrá cambiar su estado a Inactivo.  
 
    Para que los paquetes puedan ser comercializados deben crearse las salidas. Una salida es, en definitiva, un paquete en una determinada fecha y para la cual se establece una cantidad de cupos disponibles. Por lo tanto, los servicios definidos en el paquete son los que se ejecutarán como parte de la salida, aunque en ese caso al servicio se le define un cupo (que puede ser diferente al de la salida), un precio y pueden presentar características especiales, por ejemplo: para los que son transporte se tiene una ciudad de origen y otra de destino, para los de alojamiento, el hotel se encuentra en una ciudad y tiene una cantidad (1-6) de estrellas. 
 
    Lo servicios, incluidos en la salida, son proporcionados por diferentes empresas o personas físicas (conocidas como los prestadores). Por ejemplo, una noche de hotel se ofrece en el Hotel Sheraton, que pertenece a la empresa Sheraton Argentina S.A.  
 
    Similar a lo que ocurre con el paquete, al crear una salida se establece en el estado Creada, luego de definir toda la información requerida (ver requerimientos específicos) puede pasar al estado En Venta. Cuando llega la fecha de la salida (y se encuentre En Venta) pasa al estado En Ejecución. En cualquier momento se puede desactivar la salida estableciendo su estado En Pausa (siempre y cuando se encuentre En Venta). Mientras está pausada puede ser editada. Cuando se cumple el plazo de ejecución pasa al estado Finalizada (si se encuentra En Ejecución). Los paquetes no definen precios, pero si las salidas. Estos precios se determinan según la base en la que se comercialicen. La base es la tarifa que se establece según la cantidad de personas que viajan juntas y comparten la misma habitación. Las únicas bases que se manejan son: Simple, Doble, Triple, Cuádruple y Quíntuple. 
 
    A tener en cuenta para la primera iteración: 
        ● Aunque el sistema deberá contemplar la posibilidad de varios servicios, solo se tendrán en cuenta los servicios de transporte y alojamiento.
        ● No es necesario asignarle precio a todas las bases, pero debe existir por lo menos una que lo tenga.
        ● Un paquete debe contener como mínimo un servicio de transporte y un servicio de alojamiento.
        ● Las salidas deben crearse desde el paquete y solo cuando éste se encuentre Activo.
        ● Para una salida y sus servicio deben definirse los cupos, precios y las características especiales.
        ● No es necesario que un servicio se relacione con un prestador.
        ● El servicio de un prestador tiene un nombre y puede tener una descripción.
        ● País, Provincia, Ciudad y Paso Fronterizo se definen con un nombre.
        ● Tipo y Rubro se definen con una descripción 
 
4. VISIÓN GENERAL DEL PRODUCTO 
4.1. Resumen de características: 
    Para la primera iteración se espera que con el sistema se pueda: 
        ● Administrar paquetes o Crear nuevos paquetes o Modificar un paquete existente o Activar o desactivar un paquete 
        ● Administrar salidas o Crear nuevas salidas o Modificar una salida existente o Facilitar los cambios de estado de forma manual o Facilitar los cambios de estado de forma automática
