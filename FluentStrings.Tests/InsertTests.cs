﻿using System;
using dokas.FluentStrings;
using dokas.FluentStrings.Actions.Insert;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTransformerTests
{
    [TestClass()]
    public class InsertTests
    {
        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Constants

        private const string NullString = null;
        private const string NothingShouldBeChanged = "Nothing should be changed";

        #endregion

        #region Insert

        [TestMethod()]
        public void InsertTextToNullString()
        {
            string transformed = NullString.Insert("bla");
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullText()
        {
            string transformed = NothingShouldBeChanged.Insert(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextToNullString()
        {
            string transformed = NullString.Insert(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyText()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertText()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST");
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert To

        [TestMethod()]
        public void InsertNullTextToBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).To(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertTextToBeginningOfNullString()
        {
            string transformed = NullString.Insert("bla").To(Position.Beginning);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextToBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).To(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextToBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).To(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextToEndOfNullString()
        {
            string transformed = NullString.Insert(null).To(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertTextToEndOfNullString()
        {
            string transformed = NullString.Insert("bla").To(Position.End);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextToEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).To(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextToEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).To(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextToBeginning()
        {
            string transformed = "<-- TEST string will be inserted here".Insert("TEST").To(Position.Beginning);
            transformed.Should().Be("TEST<-- TEST string will be inserted here");
        }

        [TestMethod()]
        public void InsertTextToEnd()
        {
            string transformed = "TEST string will be inserted here -->".Insert("TEST").To(Position.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST");
        }

        #endregion

        #region Insert At

        [TestMethod()]
        public void InsertNullTextAtPositionInNullString()
        {
            string transformed = NullString.Insert(null).At(2);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertTextAtPositionInNullString()
        {
            string transformed = NullString.Insert("bla").At(2);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextAt()
        {
            string transformed = NothingShouldBeChanged.Insert(null).At(2);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAt()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).At(2);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAt()
        {
            string transformed = "Bla <-- TEST string will be inserted here".Insert("TEST").At(4);
            transformed.Should().Be("Bla TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert At From

        [TestMethod()]
        public void InsertNullTextAtPositionFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).At(3).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAtPositionFromBeginningOfNullString()
        {
            string transformed = NullString.Insert("bla").At(3).From(Position.Beginning);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextAtPositionFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).At(3).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAtPositionFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).At(3).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAtPositionFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).At(5).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAtPositionFromEndOfNullString()
        {
            string transformed = NullString.Insert("bla").At(3).From(Position.End);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextAtPositionFromEndOfNullString()
        {
            string transformed = NullString.Insert(null).At(3).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAtPositionFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).At(5).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAtPositionFromBeginning()
        {
            string transformed = "Bla <-- TEST string will be inserted here".Insert("TEST").At(4).From(Position.Beginning);
            transformed.Should().Be("Bla TEST<-- TEST string will be inserted here");
        }

        [TestMethod()]
        public void InsertTextAtPositionFromEnd()
        {
            string transformed = "TEST string will be inserted here --> bla".Insert("TEST").At(4).From(Position.End);
            transformed.Should().Be("TEST string will be inserted here -->TEST bla");
        }

        #endregion

        #region Insert Before

        [TestMethod()]
        public void InsertNullTextBeforeInNullString()
        {
            string transformed = NullString.Insert(null).Before(String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullInNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod()]
        public void InsertTextBeforeNullInNullString()
        {
            string transformed = NullString.Insert("bla").Before(null);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullInNullString()
        {
            string transformed = NullString.Insert(null).Before(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeInNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBefore()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNull()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNull()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBefore()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextBefore()
        {
            string transformed = "TEST string will be inserted here -->_bla".Insert("TEST").Before("_bla");
            transformed.Should().Be("TEST string will be inserted here -->TEST_bla");

            transformed = "TEST string will be inserted here -->_bla TEST string will be inserted here -->_bla".Insert("TEST").Before("_bla");
            transformed.Should().Be("TEST string will be inserted here -->TEST_bla TEST string will be inserted here -->TEST_bla");
        }

        #endregion

        #region Insert Before Occurrence

        [TestMethod()]
        public void InsertNullTextBeforeOccurrenceInNullString()
        {
            string transformed = NullString.Insert(null).Before(3, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrenceInNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(2, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrenceInNullString()
        {
            string transformed = NullString.Insert(null).Before(1, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrenceInNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(3, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(5, String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(2, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(3, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(3, String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextBeforeNonExistingOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert("TEST").Before(1, "_bla");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextBeforeOccurrence()
        {
            string transformed = "TEST string will be inserted here -->_bla But not here --X_bla".Insert("TEST").Before(1, "_bla");
            transformed.Should().Be("TEST string will be inserted here -->TEST_bla But not here --X_bla");

            transformed = "_bla Some Another Text _bla _bla And again text _bla TEST string will be inserted here -->_bla But not here --X_bla".Insert("TEST").Before(5, "_bla");
            transformed.Should().Be("_bla Some Another Text _bla _bla And again text _bla TEST string will be inserted here -->TEST_bla But not here --X_bla");
        }

        [TestMethod()]
        public void InsertTextBeforeOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "_bla<-- TEST string will be inserted before that _bla".Insert("TEST").Before(1, "_bla");
            transformed.Should().Be("TEST_bla<-- TEST string will be inserted before that _bla");

            transformed = "_bla TEST string will be inserted here -->_bla But not here --X_bla".Insert("TEST").Before(2, "_bla");
            transformed.Should().Be("_bla TEST string will be inserted here -->TEST_bla But not here --X_bla");
        }

        #endregion

        #region Insert Before Occurrence From

        [TestMethod()]
        public void InsertNullTextBeforeOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).Before(1, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(null).Before(3, String.Empty).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(2, null).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(3, null).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).Before(3, null).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(null).Before(2, null).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(3, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).Before(4, String.Empty).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextBeforeOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(3, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextBeforeOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(6, String.Empty).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(3, null).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeNullOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(2, null).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(3, null).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextBeforeNullOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).Before(3, null).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(3, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextBeforeOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).Before(2, String.Empty).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextBeforeOccurrenceFromBeginning()
        {
            string transformed = "_bla TEST string will be inserted here -->_bla But not here --X_bla".Insert("TEST").Before(2, "_bla").From(Position.Beginning);
            transformed.Should().Be("_bla TEST string will be inserted here -->TEST_bla But not here --X_bla");
        }

        [TestMethod()]
        public void InsertTextBeforeOccurrenceFromEnd()
        {
            string transformed = "_bla TEST string will be inserted here -->_bla But not here --X_bla".Insert("TEST").Before(2, "_bla").From(Position.End);
            transformed.Should().Be("_bla TEST string will be inserted here -->TEST_bla But not here --X_bla");
        }

        #endregion

        #region Insert After

        [TestMethod()]
        public void InsertNullTextAfterInNullString()
        {
            string transformed = NullString.Insert(null).After(String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullInNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(null);
            transformed.Should().Be(String.Empty);
        }

        [TestMethod()]
        public void InsertTextAfterNullInNullString()
        {
            string transformed = NullString.Insert("bla").After(null);
            transformed.Should().Be("bla");
        }

        [TestMethod()]
        public void InsertNullTextAfterNullInNullString()
        {
            string transformed = NullString.Insert(null).After(null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterInNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfter()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNull()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAfterNull()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfter()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAfter()
        {
            string transformed = "bla bla bla_<-- TEST string will be inserted here".Insert("TEST").After("bla_");
            transformed.Should().Be("bla bla bla_TEST<-- TEST string will be inserted here");
        }

        #endregion

        #region Insert After Occurrence

        [TestMethod()]
        public void InsertNullTextAfterOccurrenceInNullString()
        {
            string transformed = NullString.Insert(null).After(3, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrenceInNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(2, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrenceInNullString()
        {
            string transformed = NullString.Insert(null).After(1, null);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrenceInNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(3, String.Empty);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(3, String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(2, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(3, null);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(1, String.Empty);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAfterNonExistingOccurrence()
        {
            string transformed = NothingShouldBeChanged.Insert("TEST").After(2, "_bla");
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAfterOccurrence()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, "bla_");
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");

            transformed = "bla_ bla Some other bla_ text bla_ bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(4, "bla_");
            transformed.Should().Be("bla_ bla Some other bla_ text bla_ bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        [TestMethod()]
        public void InsertTextAfterOccurrenceWithMarkerAtBeginning()
        {
            string transformed = "bla_<-- TEST string will be inserted after that _bla".Insert("TEST").After(1, "bla_");
            transformed.Should().Be("bla_TEST<-- TEST string will be inserted after that _bla");

            transformed = "bla_ Some other text bla_<-- TEST string will be inserted here But not here --X_bla".Insert("TEST").After(2, "bla_");
            transformed.Should().Be("bla_ Some other text bla_TEST<-- TEST string will be inserted here But not here --X_bla");
        }

        #endregion

        #region Insert After Occurrence From

        [TestMethod()]
        public void InsertNullTextAfterOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).After(1, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(null).After(3, String.Empty).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(4, null).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(1, null).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(null).After(2, null).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(null).After(3, null).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrenceFromBeginningOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(6, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrenceFromEndOfNullString()
        {
            string transformed = NullString.Insert(String.Empty).After(2, String.Empty).From(Position.End);
            transformed.Should().Be(NullString);
        }

        [TestMethod()]
        public void InsertNullTextAfterOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(3, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAfterOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(2, String.Empty).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(3, null).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterNullOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(1, null).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(3, null).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertNullTextAfterNullOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(null).After(2, null).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrenceFromBeginning()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(3, String.Empty).From(Position.Beginning);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertEmptyTextAfterOccurrenceFromEnd()
        {
            string transformed = NothingShouldBeChanged.Insert(String.Empty).After(2, String.Empty).From(Position.End);
            transformed.Should().Be(NothingShouldBeChanged);
        }

        [TestMethod()]
        public void InsertTextAfterOccurrenceFromBeginning()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, "bla_").From(Position.Beginning);
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        [TestMethod()]
        public void InsertTextAfterOccurrenceFromEnd()
        {
            string transformed = "bla_ bla bla bla_<-- TEST string will be inserted here. bla_X-- But not here".Insert("TEST").After(2, "bla_").From(Position.End);
            transformed.Should().Be("bla_ bla bla bla_TEST<-- TEST string will be inserted here. bla_X-- But not here");
        }

        #endregion
    }
}
