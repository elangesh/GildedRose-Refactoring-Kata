# Gilded Rose C# Refactoring Endeavour

## Overview
This repository houses my rendition of the Gilded Rose refactoring kata - a diligent exercise in rejuvenating legacy code with modern code design principles.

## Philosophical Approach
Embarking on this endeavour, I first acquainted myself with the existing codebase. Recognising its functional integrity, my foremost endeavour was to underpin the architecture with a suite of unit tests. These tests safeguard against regressions, affording me the confidence to refactor rigorously.

Adhering to principles of SOLID, KISS, DRY, and SRP, the refactoring journey saw a diminution of nested logic and a simplification of methods, enhancing readability and maintainability.

## Refinement Journey
- Purged redundant test classes and instantiated a robust unit testing framework.
- Drafted tests mirroring business specifications, achieving thorough code coverage.
- Optimised by eliminating superfluous variables and abstracting magic numbers and strings.
- Refined arithmetic expressions and conditional logic for brevity and clarity.
- Introduced item-specific logic encapsulation, ensuring a clean and understandable codebase.
- Integrated the new 'Conjured' item category with corresponding tests and logic.
- Finalised the refactor with a strategy pattern, encapsulating business logic within discrete strategy classes.

## Compilation and Execution
To engage with the code:
- **Build**: Navigate to "Build" and select "Build Solution" in Visual Studio.
- **Run**: Opt for "Start without Debugging" under the "Debug" menu to observe the item states transition in the console.
- **Test**: Invoke unit tests by right-clicking on the `GildedRoseTests` project and selecting "Run Unit Tests".

## Reflections on the Refactor
Refactoring can be an infinite quest for perfection. Should the mythical Goblin grant leeway, the incorporation of the `UpdateQuality()` method within the `Item` class could further streamline the system, superseding the necessity for a factory.

This repository is a testament to the potential for legacy code to be revitalised through thoughtful refactoring.
