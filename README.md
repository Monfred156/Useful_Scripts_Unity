# Useful Scripts in C# for Unity

[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](http://forthebadge.com)

The goal of this repo is to provide the most useful scripts for the development of games under Unity.

## Explications

- #### StickyPlatform.cs
    In order to work sticky platform script need a tag `Player` on the player and also a 
a script called `CharacterController2D` with a public function `IsGrounded()` that return true or false in
order to call this
`other.gameObject.GetComponent<CharacterController2D>().IsGrounded()
`
- #### CharacterController2D.cs
    Work for 2D side scroller game not for top down view games.

## Made with

* [C#](https://www.qt.io/)

## Versions

## Authors

* **Alexandre Malaquin** _alias_ [@Monfred156](https://github.com/Monfred156)
