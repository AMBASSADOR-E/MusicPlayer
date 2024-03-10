# MusicPlayer
Sure, here's the README file for a console music player app I've created in C#:

## Console Music Player

This is a console application for playing and managing music playlists.

### Features

- Create a new playlist
- Add songs to a playlist
- Remove songs from a playlist
- Edit a song's metadata (title, artist, album, etc.)
- Shuffle a playlist
- Sort a playlist (by title, artist, album, etc.)
- Play songs from a playlist

### Setup

#### Requirements

- .NET Core SDK 3.1 or later

#### Installation

1. Clone this repository
2. Navigate to the root directory of the repository in a terminal or command prompt
3. Run dotnet run to start the application

### Usage

When the application starts, you will be greeted with a main menu:


====== Console Music Player ======
1. Create new playlist
2. Load existing playlist
3. Exit
Enter your choice (1-3):


- To create a new playlist, choose option 1 and follow the prompts to name the new playlist.
- To load an existing playlist, choose option 2 and select the playlist file from the list of available playlists.
- To exit the application, choose option 3.

Once you've loaded a playlist, you can use the following menu options to manage the playlist:


====== Playlist: My Playlist ======
1. Add song
2. Edit song
3. Remove song
4. Shuffle
5. Sort
6. Play
7. Back to main menu
Enter your choice (1-7):


- To add a song to the playlist, choose option 1 and enter the path to the song file, as well as its metadata (title, artist, album, etc.).
- To edit a song's metadata, choose option 2 and select the song to edit, then enter the new metadata.
- To remove a song from the playlist, choose option 3 and select the song to remove.
- To shuffle the playlist, choose option 4.
- To sort the playlist, choose option 5 and select the field to sort by (title, artist, album, etc.).
- To play the playlist, choose option 6. The playlist will be played in the order it's currently sorted.

### Example


====== Console Music Player ======
1. Create new playlist
2. Load existing playlist
3. Exit
Enter your choice (1-3): 1

Enter playlist name: My Playlist

====== Playlist: My Playlist ======
1. Add song
2. Edit song
3. Remove song
4. Shuffle
5. Sort
6. Play
7. Back to main menu
Enter your choice (1-7): 1

Enter song path: C:\Music\Song.mp3
Enter song title: Song Title
Enter song artist: Artist Name
Enter song album: Album Name

====== Playlist: My Playlist ======
1. Add song
2. Edit song
3. Remove song
4. Shuffle
5. Sort
6. Play
7. Back to main menu
Enter your choice (1-7): 5

Sort by:
1. Title
2. Artist
3. Album
Enter your choice (1-3): 1

====== Playlist: My Playlist ======
1. Add song
2. Edit song
3. Remove song
4. Shuffle
5. Sort
6. Play
7. Back to main menu
Enter your choice (1-7): 6

Playing 1 song in order:
  1. Song Title - Artist Name (Album Name)
Press any key to stop playback.

====== Playlist: My Playlist ======
1. Add song
2. Edit song
3. Remove song
4. Shuffle
5. Sort
6. Play
7. Back to main menu
Enter your choice (1-7): 7

====== Console Music Player ======
1. Create new playlist
2. Load existing playlist
3. Exit
Enter your choice (1-3): 3
