using System.Collections.Generic;
using System.Net.Mail;
using RecipeManagement.Core;

namespace RecipeManagement.Tests;

/// <summary>
/// Example tests from the assignment specification. Add your own tests as you work.
/// </summary>
public sealed class RecipeManagerTests
{
    [Fact]
    public void Constructor_BuildsRecipeDictionary()
    {
        var manager = CreateManager();
        Assert.Equal(2, manager.RecipeCount);
        Assert.Equal("Recipe A", manager.FindRecipe(10)?.Title);
    }

    [Fact]
    public void InstructionsAreCompletedInFileOrder()
    {
        var manager = CreateManager();
        Assert.True(manager.StartCooking(10));
        Assert.Equal("First step", manager.PeekNextInstruction());
        Assert.Equal("First step", manager.CompleteNextInstruction());
        Assert.Equal("Second step", manager.PeekNextInstruction());
    }

    [Fact]
    public void RemovedRecipesAreRestoredLastInFirstOut()
    {
        var manager = CreateManager();
        manager.AddRecipeToCookingPlan(10);
        manager.AddRecipeToCookingPlan(20);
        manager.RemoveRecipeFromCookingPlan(10);
        manager.RemoveRecipeFromCookingPlan(20);
        Assert.Equal(20, manager.PeekLastRemovedRecipe());
        Assert.True(manager.RestoreLastRemovedRecipe());
        Assert.Equal(new[] { 20 }, manager.GetCookingPlan());
    }

    private static RecipeManager CreateManager()
    {
        return new RecipeManager(new[]
        {
            new Recipe
            {
                Id = 10,
                Title = "Recipe A",
                Ingredients = new() { "1 apple" },
                Instructions = new() { "First step", "Second step" }
            },
            new Recipe
            {
                Id = 20,
                Title = "Recipe B"
            }
        });
    }

    // My own tests
    [Fact]
    public void DictionaryCanAddFindAndRemoveRecipe()
    {
        var manager = CreateManager();
        var recipe = new Recipe
        {
            Id = 398654,
            Title = "Recipe C",

        };

        Assert.True(manager.AddRecipe(recipe));
        Assert.Equal(recipe, manager.FindRecipe(398654));
        Assert.True(manager.RemoveRecipe(398654));
        Assert.Null(manager.FindRecipe(398654));
    }

    [Fact]
    public void CannotAddDuplicateRecipeId()
    {
        var manager = CreateManager();
        var recipe = new Recipe
        {
            Id = 398654,
            Title = "Duplicate Recipe"
        };
        Assert.True(manager.AddRecipe(recipe));
        Assert.False(manager.AddRecipe(recipe));
        Assert.Equal(3, manager.RecipeCount);
        Assert.Equal("Duplicate Recipe", manager.FindRecipe(398654)?.Title);
    }

    [Fact]
    public void MissingRecipeIdIsHandled()
    {
        var manager = CreateManager();

        Assert.Null(manager.FindRecipe(50));
        Assert.False(manager.RemoveRecipe(50));
        Assert.Equal(2, manager.RecipeCount);
    }

    [Fact]
    public void ShoppingListCanAddGetAndClearIngredients()
    {
        var manager = CreateManager();

        Assert.Equal(1, manager.AddIngredientsToShoppingList(10));
        Assert.Equal(1, manager.ShoppingItemCount);
        Assert.Equal(new[] { "1 apple" }, manager.GetShoppingList());

        manager.ClearShoppingList();
        Assert.Empty(manager.GetShoppingList());
        Assert.Equal(0, manager.ShoppingItemCount);
    }

    [Fact]
    public void CookingPlanCanAddGetAndRemoveRecipes()
    {
        var manager = CreateManager();

        Assert.True(manager.AddRecipeToCookingPlan(10));
        Assert.True(manager.AddRecipeToCookingPlan(20));
        Assert.Equal(2, manager.CookingPlanCount);
        Assert.Equal(new[] { 10, 20 }, manager.GetCookingPlan());
        Assert.True(manager.RemoveRecipeFromCookingPlan(10));
        Assert.Equal(1, manager.CookingPlanCount);
        Assert.Equal(new[] { 20 }, manager.GetCookingPlan());
    }

    [Fact]
    public void CannotAddDuplicateRecipeToCookingPlan()
    {
        var manager = CreateManager();

        Assert.True(manager.AddRecipeToCookingPlan(20));
        Assert.False(manager.AddRecipeToCookingPlan(20));
        Assert.Equal(1, manager.CookingPlanCount);
        Assert.Equal(new[] { 20 }, manager.GetCookingPlan());
    }

    [Fact]
    public void EmptyRemovedRecipeStackIsHandled()
    {
        var manager = CreateManager();

        Assert.Equal(0, manager.RemovedRecipeCount);
        Assert.Null(manager.PeekLastRemovedRecipe());
        Assert.False(manager.RestoreLastRemovedRecipe());
    }

    [Fact]
    public void CookingInstructionsUseQueueInOrder()
    {
        var manager = CreateManager();

        Assert.True(manager.StartCooking(10));
        Assert.Equal(2, manager.PendingInstructionCount);
        Assert.Equal("First step", manager.PeekNextInstruction());
        Assert.Equal("First step", manager.CompleteNextInstruction());
        Assert.Equal(1, manager.PendingInstructionCount);
        Assert.Equal("Second step", manager.CompleteNextInstruction());
        Assert.Equal(0, manager.PendingInstructionCount);
    }
}
