"# GAMF/Game Development/4th lecture, 2024-03-21" 

Gameobject elérése a scriptből:

1. A script gazdája: a gameObject változóban benne van, mint pl: transform

2. Ütközésben az eseménykezelő paraméterében benne van, pl.: OnCollisionEnter2D( Collision2D c ) { c.gameObject... }

3. Ha tudom a nevét: gameobject g = GameObject.Fin("Nev")

4. A script osztályban a public tagok elérhetőek a szerkesztőből és lehet nekik értéket adni.


GameObject dinamikus törlése:
(GameObject).Destroy(g.o-instance)
pl.: Destroy(GameObject)

GameObject dinamuus klónozása:
GameObject clone = GameObject.Instentiate(prototipus GameObject peldany)

Random object generálás:
Random.
Inst. prefab-ból
	- prefab készítése
	- A public GameObject tagba behúzzuk a prefabot
