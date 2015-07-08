function solve(){
	var module = (function(){
        var player,
            validator;

        validator = (function(){
            var MIN_LENGTH = 3,
                MAX_LENGTH = 25;

            function validateString(value){
                if(!value || 
                        value.length < MIN_LENGTH ||
                        value.length > MAX_LENGTH ||
                        typeof value != 'string'){
                    throw new Error('Invalid string input');
                }
            },
            function validateNumeric(value){
                if(typeof id != number){
                    throw new Error("Invalid Numeric Value");
                }
            }

            function findEntityIndexInCollection(id, collection){
                for(var i = 0, len = collection.length; i < len; i++){
                    if(id === collection[i].id){
                        return i;
                    }
                }

                return -1;
            }


            return{
                validateString: validateString,
                validateNumeric: validateNumeric,
                findEntityIndexInCollection: findEntityIndexInCollection
            }
        }());

        player = (function(){
            var _playerID = 0,
                _player = {};

            Object.defineProperties('player', {
                init:{
                    value: function(name){
                        this.name = name;
                        this._playlists = [];
                        this._id = ++playerID;
                        return this;
                    })
                },
                name:{
                    get:function(){
                        return this._name;
                    },
                    set: function(name){
                        validator.validateString(name);
                        this._name = name;
                    }
                },
                id:{
                    get: function(){
                        return this._id;
                    }
                },
                addPlaylist:{
                    value: function(playlistToAdd){
                        if(findEntityIndexInCollection(playlistToAdd.id, this._playlists)){
                            this._playlists.push(playlistToAdd);
                            return playlistToAdd;
                        }

                        return null;
                    }
                },
                removePlaylist: {
                    value:function(valueToRemove){
                        var indexToRemove;
                        if(typeof valueToRemove === 'object' && 'id' in valueToRemove){
                            indexToRemove = findEntityIndexInCollection(valueToRemove.id, this._playlists);
                        }else{
                            indexToRemove = findEntityIndexInCollection(valueToRemove, this._playlists);
                        }

                        if(indexToRemove > -1){
                            this._playlists.splice(indexToRemove,1);
                            return this;
                        }
                        else{
                            throw new Error("Removing Playlist Failed: Index does not exist in collection");
                        }
                    }
                },
                getPlaylistById:{
                    value: function(idToFind){
                        correspondingIndex = findEntityIndexInCollection(idToFind, this._playlists);
                        if(correspondingIndex > -1){
                            return this._playlists[correspondingIndex];
                        }

                        return null;
                    }
                }

            });




        }());





        return {
    	    getPlayer: function (name){
    	        // returns a new player instance with the provided name
    	    },
    	    getPlaylist: function(name){
    	        //returns a new playlist instance with the provided name
    	    },
    	    getAudio: function(title, author, length){
    	        //returns a new audio instance with the provided title, author and length
    	    },
    	    getVideo: function(title, author, imdbRating){
    	        //returns a new video instance with the provided title, author and imdbRating
    	    }
        }
	}())

	return module;
}

var module = solve();