usando  o sistema ;
Usando  UnityEngine ;
usando  TMPro ;
usando  HarmonyLib ;
usando  UnityEngine.SceneManagement ;
// Usos nocivos estão bloqueados, nem tente, rsrs.
// O Harmony não é recomendado por diversos motivos de compatibilidade, portanto, você deve criar soluções baseadas em eventos em vez de usar o Harmony.

 classe  pública DynamicCode
{    
    público  void  Execute ( )
    {
        Debug.Log ( "Pré- carregador de ativos online inicializado." ) ;

        SceneManager.activeSceneChanged + = delegate ( Scene oldScene , Scene scene )     
	{
            se  ( scene.name == " MainMenu " )  
            {
                ExecuteMainMenu ( "mudança de cena" ) ;
            }
	} ;
	MUEventManager.Instance.OnEventCalled ( " MainMenuManager :: Start ::Postfix" , ( parameters ) =>  
        {
            ExecuteMainMenu ( "evento" ) ;
        } ) ;
    }

    público  void  ExecuteMainMenu ( string  caller )
    {
        Debug.Log ( " Menu principal conectado e carregado. via " + caller ) ;  
    }
}
