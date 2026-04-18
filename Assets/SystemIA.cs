using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI; 

public class SystemeIA : MonoBehaviour
{
   
    public TextMeshProUGUI texteAR;

    
    public Button boutonAnalyse;

    
    public GameObject modele3D;

    private bool isAnalyzing = false;

    void Start()
    {
        // On s'assure que le modèle est caché au démarrage [cite: 44]
        if (modele3D != null) modele3D.SetActive(false);

        // Message d'accueil
        if (texteAR != null) texteAR.text = "Prêt pour le scan...";
    }

    public void LancerAnalyse()
    {
        // On empêche de relancer si une analyse est déjà en cours
        if (!isAnalyzing)
        {
            StartCoroutine(SimulerProcessusIA());
        }
    }

    private IEnumerator SimulerProcessusIA()
    {
        isAnalyzing = true;

        // Désactiver le bouton pendant le calcul
        if (boutonAnalyse != null) boutonAnalyse.interactable = false;

        // Étape 1 : Détection (Analyse visuelle) [cite: 23, 24]
        texteAR.text = "🔍 <color=#3498db>Analyse des capteurs...</color>";
        yield return new WaitForSeconds(1.5f);

        // Étape 2 : Comparaison (Cloud/Base de données) [cite: 29, 36]
        texteAR.text = "⚙️ <color=#e67e22>Identification du sujet...</color>";
        yield return new WaitForSeconds(1.5f);

        // Étape 3 : Résultat et Affichage [cite: 42, 49]
        AfficherResultat();

        isAnalyzing = false;

        // Réactiver le bouton si on veut refaire un scan
        if (boutonAnalyse != null) boutonAnalyse.interactable = true;
    }

    private void AfficherResultat()
    {
        // Données adaptées à l'image de la voiture scannée
        texteAR.text = "<color=#2ecc71>🚗 VÉHICULE IDENTIFIÉ :</color>\n" +
                       "<b>Modèle :</b> Sportive Rouge\n" +
                       "<b>Moteur :</b> V8 Bi-Turbo\n" +
                       "<b>Vitesse max :</b> 320 km/h";

        // Activation de l'objet 3D (ex: des roues en 3D ou un moteur)
        if (modele3D != null)
        {
            modele3D.SetActive(true);
        }
    }
}