package com.nikonhacker;


import com.nikonhacker.dfr.OutputOption;
import com.nikonhacker.emu.trigger.BreakTrigger;
import com.nikonhacker.gui.EmulatorUI;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.StaxDriver;

import java.io.*;
import java.nio.charset.Charset;
import java.util.*;

public class Prefs {    
    int sleepTick = 2;
    List<BreakTrigger> triggers;
    Set<OutputOption> outputOptions;

    private HashMap<String, WindowPosition> windowPositionMap;


    public static File getPreferenceFile() {
        return new File(System.getProperty("user.home") + File.separator + "." + EmulatorUI.APP_NAME);
    }

    public static void save(Prefs prefs) {
        save(prefs, getPreferenceFile());
    }

    public static Prefs load() {
        return (Prefs) load(getPreferenceFile());
    }

    public static void save(Object object, File file) {
        XStream xStream = new XStream(new StaxDriver());
        OutputStream outputStream = null;
        Writer writer = null;

        try {
            outputStream = new FileOutputStream(file);
            writer = new OutputStreamWriter(outputStream, Charset.forName("UTF-8"));
            xStream.toXML(object, writer);
        }
        catch (Exception e) {
            e.printStackTrace();
        }
        finally {
            try {
                if (writer!= null) writer.close();
                if (outputStream!=null) outputStream.close();
            } catch (IOException e) {
                //noop
            }
        }
    }

    public static Object load(File file) {
        if (file.exists()) {
            Object object = null;
            XStream xStream = new XStream(new StaxDriver());
            InputStream inputStream = null;
            Reader reader = null;

            try {
                inputStream = new FileInputStream(file);
                reader = new InputStreamReader(inputStream, Charset.forName("UTF-8"));
                object = xStream.fromXML(reader);
            }
            catch (Exception e) {
                e.printStackTrace();
            }
            finally {
                try {
                    if (reader!= null) reader.close();
                    if (inputStream!=null) inputStream.close();
                } catch (IOException e) {
                    //noop
                }
            }
            return object;
        }
        else {
            return new Prefs();
        }
    }

    public int getSleepTick() {
        return sleepTick;
    }

    public void setSleepTick(int sleepTick) {
        this.sleepTick = sleepTick;
    }

    public Set<OutputOption> getOutputOptions() {
        if (outputOptions==null) outputOptions = EnumSet.noneOf(OutputOption.class);
        return outputOptions;
    }

    public void setOutputOption(OutputOption outputOption, boolean value) {
        if (outputOptions==null) outputOptions = EnumSet.noneOf(OutputOption.class);
        if (value) {
            outputOptions.add(outputOption);
        }
        else {
            outputOptions.remove(outputOption);
        }
    }



    public List<BreakTrigger> getTriggers() {
        if (triggers == null) triggers = new ArrayList<BreakTrigger>();
        return triggers;
    }

    public void setTriggers(List<BreakTrigger> triggers) {
        this.triggers = triggers;
    }

    public int getWindowPositionX(String windowName) {
        if (windowPositionMap==null) windowPositionMap = new HashMap<String, WindowPosition>();
        WindowPosition windowPosition = windowPositionMap.get(windowName);
        return (windowPosition==null)?0:windowPosition.getX();
    }

    public int getWindowPositionY(String windowName) {
        if (windowPositionMap==null) windowPositionMap = new HashMap<String, WindowPosition>();
        WindowPosition windowPosition = windowPositionMap.get(windowName);
        return (windowPosition==null)?0:windowPosition.getY();
    }

    public void setWindowPosition(String windowName, int x, int y) {
        if (windowPositionMap==null) windowPositionMap = new HashMap<String, WindowPosition>();
        windowPositionMap.put(windowName, new WindowPosition(x, y));
    }

    public class WindowPosition {
        int x = 0;
        int y = 0;
        
        public WindowPosition() {
        }

        public WindowPosition(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int getX() {
            return x;
        }

        public void setX(int x) {
            this.x = x;
        }

        public int getY() {
            return y;
        }

        public void setY(int y) {
            this.y = y;
        }
    }
}
