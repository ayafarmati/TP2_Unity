## Description du projet
Ce projet consiste en le développement d'une application de réalité augmentée (AR) sous Unity intégrant une simulation d'intelligence artificielle. L'application permet de détecter un objet réel via la caméra et de déclencher une analyse intelligente pour afficher des informations enrichies.

## Objectifs du TP
- Détecter un élément réel (image ou plan).
- Intégrer une fonctionnalité d'intelligence artificielle.
- Permettre une interaction utilisateur en temps réel.
- Afficher un contenu virtuel dynamique basé sur l'analyse.

## Technologies utilisées
- Unity
- Vuforia Engine (pour la détection d'image target) 
- Langage C# pour la logique de l'IA

## Fonctionnalités
- Initialisation AR : Configuration de la caméra et détection de la cible.
- Simulation IA : Processus d'analyse en trois étapes (Détection, Comparaison, Résultat).
- Interaction : Bouton permettant de lancer l'analyse manuellement.
- Affichage : Présentation des caractéristiques techniques de l'objet détecté et activation d'un modèle 3D.

## Installation et Test
1. Télécharger le fichier tp2_app.apk situé à la racine du dépôt.
2. Installer l'application sur un appareil Android.
3. Autoriser l'accès à la caméra lors du lancement.
4. Pointer l'image cible et cliquer sur le bouton "Lancer l'Analyse".

## Structure du dépôt
- Assets : Scripts C#, scènes et ressources du projet.
- ProjectSettings : Paramètres de configuration Unity et Vuforia.
- tp2_app.apk : Fichier exécutable pour Android.

---
