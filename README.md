<h1>Curso XR Plugin 🥽</h1>
<h2>Instalar XR Plugin en tu proyecto 🧩</h2>
<ol>
  <li>Verificar que Android si este instalado desde el Build Settings</li>
  <li>Edit - Project Settings - XR Plugin Management</li>
  <li>Install XR Plugin Management</li>
  <li>Activar Open XR en escritorio y en Android</li>
  <li>Admitir el tipo de dispositivo</li>
  <li>Entrar a la nueva ventana "OpenXR"</li>
  <li>Agregar en "Enabled Interaction Profiles" los mandos deseados, repetir esto en el escritorio como en Android</li>
</ol>
<h2>Kit de herramientas 🔧</h2>
<ul>
  <li>Descargar el ToolKit y started assets (Ruta: Package Manager/+/add package by name) "com.unity.xr.interaction.toolkit"</li>
  <li><strong>Mano Prefab: </strong><a href="https://drive.google.com/file/d/10b39IekUdpBHlcTslZ-BlNRyH5uqPUe1/view">Link de descarga</a></li>
  <li><strong>Pistola Prefab: </strong><a href="https://drive.google.com/file/d/1C5Fn4Yq79yof4X1lkl0MIYzVqY_UBz3M/view">Link de descarga</a></li>
</ul>
<h2>Componentes 📚</h2>
<ul>
  <li><strong>Tracked Pose Driver:</strong> cámara con movimiento en VR</li>
  <li><strong>XR controller:</strong> configurar los controles</li>
  <li><strong>Locomotion System:</strong> Medios que proporciona XR para el movimiento en una escena</li>
  <li><strong>Continuous Move Provider (Action-Based):</strong> Movimiento continuo</li>
  <li><strong>Continuous Turn Provider (Action-based):</strong> Giro continuo</li>
  <li><strong>Snap Turn Provider (Action-based):</strong> Giro quebrado</li>
  <li><strong>Character Controller Driver:</strong> para tener un mejor manejo del character controller</li>
  <li><strong>XR Direct interactor:</strong> Componente para el interactuante</li>
</ul>
<h2>Configuración Cámara 🎥</h2>
<ol>
  <li>Agregamos al main camara el componente Tracked Pose Driver, con esto ya tenemos la camara lista</li>
  <li>XR trae una camara ya configurada de la mejor manera, para utilizarla en la escena</li>
  <li>Click derecho en jerarquía XR/XR Origin VR</li>
</ol>
<h2>Configuración controles 🕹️</h2>
<ol>
  <li>Creamos dos empty uno será "Left Controller" y "Right Controller"</li>
  <li>Agregamos el componente "XR controller (Action base)" a ambos empty</li>
  <li>Si descargamos los starteds assets podemos configurar rápidamente los controles agregando las propiedades (Ruta: Samples/2.5.3/Starter Assets/Presets) "XR Default Left Controller" y "XR Default Right Controller"</li>
  <li>En el empty "XR Origin (XR rig)" fijarnos que tenga el componente "Input Action Manager" con el action "XR Default Input Actions" de lo contrario se lo debemos agregar</li>
  <li>Si deseamos algún modelo para las manos, podemos ponerlos como hijo del empty previamente creado</li>
</ol>
