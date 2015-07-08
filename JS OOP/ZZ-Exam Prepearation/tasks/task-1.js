function solve(){
    var module = (function(){
        var player,
            playlist,
            playable,
            audio,
            video,
            validator,
            helpers;

        helpers = (function(){
            function sortByNameThenById(a,b){
                if(a.name === b.name){
                    return a.id - b.id;
                }
                        
                return a.name > b.name ? 1 : -1;
            }
            
            return {
                sortByNameThenById: sortByNameThenById
            }
        }())

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
            }
            
            function validateNumeric(value){
                if(typeof value != 'number'){
                    throw new Error("Invalid Numeric Value");
                }
            }
            
            function validatePositiveNumber(value){
                if(typeof value != 'number' || value < 0){
                    throw new Error("Invalid Numeric Value: Should Be Positive Numebr");
                }
            }
            
            function validateGreaterThanZero(value){
                if(typeof value != 'number' || value <= 0){
                    throw new Error("Invalid Numeric Value: Should Be Greater Than Zero");
                }
            }
            
            function validateNumberIsInRange(value, minValue, maxValue){
                if(typeof value != 'number' || value < minValue || value > maxValue){
                    throw new Error("Invalid Numeric Value: Should Be in Range:"+ minValue + "-" + maxValue);
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
                findEntityIndexInCollection: findEntityIndexInCollection,
                validatePositiveNumber: validatePositiveNumber,
                validateGreaterThanZero: validateGreaterThanZero,
                validateNumberIsInRange: validateNumberIsInRange
            }
        }());

        player = (function(){
            var _playerID = 0,
                _player = {};
                
            Object.defineProperties(_player, {
                init:{
                    value: function(name){
                        this.name = name;
                        this._playlists = [];
                        this._id = ++_playerID;
                        return this;
                    }
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
                getPlayer: {
                    value:function(name){
                        return Object.create(_player).init(name);
                    }
                },
                addPlaylist:{
                    value: function(playlistToAdd){
                        if(typeof playlistToAdd.id === 'undefined' || !playlistToAdd.name){
                            throw new Error('Adding Playlist Failed: Playlist is not a Valid Type');
                        }
                        if(validator.findEntityIndexInCollection(playlistToAdd.id, this._playlists) < 0){
                            this._playlists.push(playlistToAdd);
                            return this;
                        }

                        return null;
                    }
                },
                removePlaylist: {
                    value:function(valueToRemove){
                        var indexToRemove;
                        if(typeof valueToRemove === 'object' && 'id' in valueToRemove){
                            indexToRemove = validator.findEntityIndexInCollection(valueToRemove.id, this._playlists);
                        }else{
                            indexToRemove = validator.findEntityIndexInCollection(valueToRemove, this._playlists);
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
                        correspondingIndex = validator.findEntityIndexInCollection(idToFind, this._playlists);
                        if(correspondingIndex > -1){
                            return this._playlists[correspondingIndex];
                        }

                        return null;
                    }
                },
                listPlaylists: { 
                    value: function(page, size){
                        var startIndex = page * size,
                            endIndex = (page + 1) * size;

                        validator.validatePositiveNumber(page);
                        validator.validateGreaterThanZero(size);
                        validator.validateNumberIsInRange(startIndex, 0, this._playlists.length);
                            
                        this._playlists.sort(helpers.sortByNameThenById);
                        return this._playlists.slice(startIndex, endIndex);
                    }
                },
                contains: {
                    value: function(playable, playlist){
                        if(playlist.getPlayableById(playable.id)){
                            return true;
                        }
                        
                        return false;
                    }
                }
            });
            
            return _player;
        }());

        playlist = (function(){
            var _playlist = {},
                _playlistID = 0;

            Object.defineProperties(_playlist, {
                init:{
                    value: function(name){
                        this.name = name;
                        this._id = ++_playlistID;
                        this._playables = [];
                        return this;
                    }
                },
                name: {
                    get: function(){
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
                addPlayable:{
                    value: function(playable){
                        if(typeof(playable.id) === 'undefined' || !playable.name ){
                            throw new Error(playable.id + '|' + playable.name + 'Adding Playable Failed: Playable Was Not a Valid Type');
                        }

                        this._playables.push(playable);
                        return this;
                    }
                },
                getPlayableById: {
                    value: function(idToFind){
                        correspondingIndex = validator.findEntityIndexInCollection(idToFind, this._playables);
                        
                        if(correspondingIndex > -1){
                            return this._playables[correspondingIndex];
                        }

                        return null;
                    }
                },
                removePlayable: {
                    value:function(valueToRemove){
                        var indexToRemove;
                        if(typeof valueToRemove === 'object' && 'id' in valueToRemove){
                            indexToRemove = validator.findEntityIndexInCollection(valueToRemove.id, this._playables);
                        }else{
                            indexToRemove = validator.findEntityIndexInCollection(valueToRemove, this._playables);
                        }

                        if(indexToRemove > -1){
                            this._playables.splice(indexToRemove,1);
                            return this;
                        }
                        else{
                            throw new Error('Removing Playable Failed: Index does not exist in collection');
                        }                
                    }
                },
                listPlayables: {
                    value: function(page, size){
                        var startIndex = page * size,
                            endIndex = (page + 1) * size;
                            
                        validator.validatePositiveNumber(page);
                        validator.validateGreaterThanZero(size);
                        validator.validateNumberIsInRange(startIndex,0, this._playables.length);
                            
                        this._playables.sort(helpers.sortByNameThenById);
                        return this._playables.slice(startIndex, endIndex);
                    }
                }
            })
            
            return _playlist;
        }());
        
        playable = (function(){
            var _playable = {},
                _playableID = 0;
                
            Object.defineProperties(_playable, {
                init: {
                    value: function(name, author){
                        this._id = ++_playableID;
                        this.name = name;
                        this.author = author;
                    }
                },
                id:{
                    get: function(){
                        return this._id;
                    }
                },
                name:{
                    get: function(){
                        return this._name;
                    },
                    set: function(name){
                        validator.validateString(name);
                        this._name = name;
                    }
                },
                author:{    
                    get: function(){
                        return this._author;
                    },
                    set: function(author){
                        validator.validateString(author);
                        this._author = author;
                    }
                },
                play: {
                    value: function(){
                        return this._id +'. ' + this._name + ' - ' + this._author;
                    }
                }
            });
            
            return _playable;
            
        }());
        
        audio = (function(parent){
            var _audio = Object.create(parent);
            
            Object.defineProperties(_audio, {
                init: {
                    value: function(name, author, length){
                        parent.init.call(this, name, author);
                        this.length = length;
                        return this;
                    }
                },
                length: {
                    get: function(){
                        return this._length;
                    },
                    set: function(length){
                        validator.validateGreaterThanZero(length);
                        this._length = length;
                    }
                },
                play:{
                    value: function(){
                        var result = parent.play.call(this);
                        result += ' - ' + this._length;
                        return result;
                    }
                }
            });
            
            return _audio;
        }(playable));
        
        video = (function(parent){
            var _video = Object.create(parent);
            
            Object.defineProperties(_video, {
                init: {
                    value: function(name, author, imdbRating){
                        parent.init.call(this, name, author);
                        this.imdbRating = imdbRating;
                        return this;
                    }
                },
                imdbRating: {
                    get: function(){
                        return this._imdbRating;
                    },
                    set: function(imdbRating){
                        validator.validateNumberIsInRange(imdbRating, 3, 25);
                        this._imdbRating = imdbRating;
                    }
                },
                play:{
                    value: function(){
                        var result = parent.play.call(this);
                        result += ' - ' + this._imdbRating;
                        return result;
                    }
                }
            });
            
            return _video;
        }(playable));

        return {
            getPlayer: function (name){
                return Object.create(player).init(name);
            },
            getPlaylist: function(name){
                return Object.create(playlist).init(name);
            },
            getAudio: function(name, author, length){
                return Object.create(audio).init(name, author, length);
            },
            getVideo: function(name, author, imdbRating){
                return Object.create(video).init(name, author, imdbRating);
            }
        }
    }())

    return module;
}